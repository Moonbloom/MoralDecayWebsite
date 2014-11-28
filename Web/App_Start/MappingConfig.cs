﻿using AutoMapper;
using Core.DomainModel;
using Web.Models;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Web.App_Start.MappingConfig), "Start")]

namespace Web.App_Start
{
    public class MappingConfig
    {
        public static void Start()
        {
            Mapper.CreateMap<TestViewModel, Test>().ReverseMap();
        }
    }
}