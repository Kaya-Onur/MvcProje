﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstraact
{
    public interface IImageFileService
    {
        List<ImageFile> GetList();
        

    }
}
