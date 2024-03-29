﻿using BufaTicket.TicketManagement.Application.Contracts.Infrastructure;
using BufaTicket.TicketManagement.Application.Features.Events.Queries.GetEventsExport;
using CsvHelper;
using System.Collections.Generic;
using System.IO;

namespace BufaTicket.TicketManagement.Infrastructure.FileExport
{
    public class CsvExporter : ICsvExporter
    {
        public byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos)
        {
            using var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                using var csvWriter = new CsvWriter(streamWriter);
                csvWriter.WriteRecords(eventExportDtos);
            }

            return memoryStream.ToArray();
        }
    }
}
