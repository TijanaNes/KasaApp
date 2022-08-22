﻿using Application.Core;
using Application.Dto.SubTypesDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.SubTypes
{
    public interface INewSubType : ICommand<NewSubTypeDto>
    {
    }
}
