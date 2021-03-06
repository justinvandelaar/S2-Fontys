﻿using Factory;
using KillerAppS2DTO;
using KillerAppS2Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KillerAppS2Logic
{
    public class TemplateContainer
    {
        private ITemplateLogic<TemplateDTO> TemplateDalLogic { get; }

        public TemplateContainer()
        {
            TemplateDalLogic = TemplateFactory.CreateTemplateDALLogic();
        }

        public string UpdateTemplate(string templateName, int templateId, TemplateDTO templateDTO)
        {
            string result = TemplateDalLogic.UpdateTemplate(templateId, templateDTO, templateName);
            return result;
        }
    }
}
