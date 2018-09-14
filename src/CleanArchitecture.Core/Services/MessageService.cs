﻿using CleanArchitecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Services
{
    public class MessageService : IMessageService
    {
        public Task SendEmailViaSendgridAsync(string Email, string Recepient, string Subject, string BCC, string CC, string Body, string Url, string UserID, string Password)
        {
            return Task.FromResult(0);
        }

        public Task SendEmailViaSMTPAsync(string Email, string Recepient, string Subject, string BCC, string CC, string Body, string Url, string UserID, string Password, string Port)
        {
            return Task.FromResult(0);
        }

        public Task SendMessageAsync(string Mobile, string Message, string Url, string SerderID, string UserID, string Password)
        {
            return Task.FromResult(0);
        }

        public Task SendNotificationAsync(string DeviceID, string Message, string Url)
        {
            return Task.FromResult(0);
        }
    }
}