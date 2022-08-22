using Application.Core;
using Application.Dto.BillsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Bills
{
    public interface IAddBillDetail : ICommand<AddBillDetailDto>
    {
    }
}
