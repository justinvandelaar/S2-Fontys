﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KillerAppS2DTO
{
    public class TemplateDTO
    {
        //Location fields
        private int _locationId;
        private string _name;
        private string _title;
        private string _story;
        private int _areaId;
        private string _fotoUrl;

        public int LocationId { get => _locationId; set => _locationId = value; }
        public string Name { get => _name; set => _name = value; }
        public string Title { get => _title; set => _title = value; }
        public string Story { get => _story; set => _story = value; }
        public int AreaId { get => _areaId; set => _areaId = value; }
        public string FotoUrl { get => _fotoUrl; set => _fotoUrl = value; }

        public TemplateDTO()
        {

        }

        public TemplateDTO(int locationId, string name, string title, string story, int areaId, string fotoUrl)
        {
            LocationId = locationId;
            Name = name;
            Title = title;
            Story = story;
            AreaId = areaId;
            FotoUrl = fotoUrl;
        }
    }
}
