﻿using nl.fhict.IntelliCloud.Business.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace nl.fhict.IntelliCloud.Service
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IntelliCloudManager manager;

        public FeedbackService()
        {
            this.manager = new IntelliCloudManager();            
        }

        public void AcceptAnswer(string feedback, string answerId, string questionId)
        {
            manager.AcceptAnswer(feedback, answerId, questionId);
        }

        public void DeclineAnswer(string feedback, string answerId, string questionId)
        {
            manager.DeclineAnswer(feedback, answerId, questionId);
        }
    }
}
