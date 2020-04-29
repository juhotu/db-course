﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Views
{
    interface ITransactionView
    {
        void Create();
        void Read();
        void Update();
        void Delete();
    }
}
