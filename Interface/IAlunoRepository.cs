﻿using API.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interface
{
    public interface IAluno_Repository
    {
        List<Aluno> Listar();
    }
}
