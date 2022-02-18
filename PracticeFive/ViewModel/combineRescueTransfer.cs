using PracticeFive.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PracticeFive.ViewModel
{
    public class combineRescueTransfer
    {
        public IEnumerable<tRescue> tRescue { get; set; }
        public IEnumerable<tTransfer> tTransfer { get; set; }

    }
}