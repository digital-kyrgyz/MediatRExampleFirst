﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorExample.MediatR.Queries
{
    public class GetAllProductQuery:IRequest<List<GetProductViewModel>>
    {

        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductViewModel>>
        {
            public Task<List<GetProductViewModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var model = new GetProductViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Book "
                };
                var model2 = new GetProductViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Monitor"
                };
                return Task.FromResult(new List<GetProductViewModel>() { model });
            }
        }
    }

}
