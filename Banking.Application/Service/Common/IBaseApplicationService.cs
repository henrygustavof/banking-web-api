﻿namespace Banking.Application.Service.Common
{
    using Banking.Application.Dto.Common;

    public interface IBaseApplicationService<TEntityInput , TEntityOutPut>
    {
        TEntityOutPut Get(int id);

        PaginationResultDto GetAll(int page, int pageSize);

        int Add(TEntityInput entity);

        int Update(int id, TEntityInput entity);

    }
}
