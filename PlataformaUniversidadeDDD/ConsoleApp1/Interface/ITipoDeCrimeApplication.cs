﻿using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Interface
{
    public interface ITipoDeCrimeApplication
    {
        void DeleteTipoDeCrime(int TipoID);
        List<TipoDeCrime> GetTipoDeCrime();
        TipoDeCrime GetTipoDeCrimeById(int id);
        void InsertTipoDeCrime(TipoDeCrime tipoDeCrime);
        void UpdateTipoDeCrime(TipoDeCrime tipoDeCrime);
    }
}
