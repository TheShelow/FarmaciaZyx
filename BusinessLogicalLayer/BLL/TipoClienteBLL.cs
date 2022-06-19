﻿using DataAccessLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class TipoClienteBLL
    {
        public DataResponse<TipoFuncionario> GetAll()
        {
            TipoClienteDAL tipoClienteDAL = new TipoClienteDAL();
            DataResponse<TipoFuncionario> dataResponse = tipoClienteDAL.GetAll();
            if (dataResponse.HasSuccess)
            {
                return new DataResponse<TipoFuncionario>(dataResponse.Message, true, dataResponse.Dados);
            }
            else
            {
                return new DataResponse<TipoFuncionario>(dataResponse.Message, dataResponse.HasSuccess, null);
            }
        }

    }
}