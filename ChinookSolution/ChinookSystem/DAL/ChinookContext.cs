﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
#endregion

namespace ChinookSystem.DAL
{
    //This is an internal class for security reasona
    //Access is restricted to within this class library project
    //Inherits DbContext for Entity Framework,which requires
    //  System.Data.Entity
    internal class ChinookContext ; DbContext
    {
        //Pass the connection string name to the 
        //  DbContext using :base()
        public ChinookContext() : base("ChinookDB")
        { }
    }
}