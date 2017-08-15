﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMES.AspNetDTM.ICore.IPCM
{
    [InheritedExport]
    public interface ICutStockSrv
    {
        
        DataTable QueryCutStockMat(string key);

        DataTable QueryCutStockBatchList(string materialcd);

        DataTable QueryBatchLockDetail(string lot);
    }
}
