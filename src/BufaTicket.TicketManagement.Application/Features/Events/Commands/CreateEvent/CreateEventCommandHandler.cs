using AutoMapper;
using BufaTicket.TicketManagement.Application.Contracts.Infrastructure;
using BufaTicket.TicketManagement.Application.Contracts.Persistence;
using BufaTicket.TicketManagement.Application.Models.Mail;
using BufaTicket.TicketManagement.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BufaTicket.TicketManagement.Application.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, Guid>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private readonly ILogger<CreateEventCommandHandler> _logger;

        public CreateEventCommandHandler(
            IEventRepository eventRepository,
            IMapper mapper,
            IEmailService emailService, 
            ILogger<CreateEventCommandHandler> logger)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
            _emailService = emailService;
            _logger = logger;
        }

        public async Task<Guid> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateEventCommandValidator(_eventRepository);
            var validationResult = await validator.ValidateAsync(request);

            if(validationResult.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResult);
            }

            var @event = _mapper.Map<Event>(request);

            _logger.LogInformation($"Criando Evento {request.Artist}!");

            @event = await _eventRepository.AddAsync(@event);

            //Sending email notification to admin address
            var email = new Email() { To = "gill@snowball.be", Body = $"A new event was created: {request}", Subject = "A new event was created" };

            try
            {
                //await _emailService.SendEmail(email);
            }
            catch (Exception ex)
            {
                //this shouldn't stop the API from doing else so this can be logged
                _logger.LogError($"Mailing about event {@event.EventId} failed due to an error with the mail service: {ex.Message}");
            }

            return @event.EventId;
        }
    }
}
