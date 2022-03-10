﻿using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstruct
{
    public interface IHeadingService
    {
        List<Heading> GetList();
        List<Heading> GetListByWriter(int id);
        void HeadingAddBL(Heading heading);
        Heading GetByID(int id);
        void HeadingDeleteBL(Heading heading);
        void HeadingUpdateBL(Heading heading);
    }
}
