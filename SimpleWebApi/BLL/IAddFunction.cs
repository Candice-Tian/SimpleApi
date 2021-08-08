using Microsoft.AspNetCore.Mvc;
using SimpleWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApi.BLL
{
    public  interface IAddFunction
    {
        public ActionResult<int> Add(AddItems addItems);
    }

    public class AddFunction : IAddFunction
    {
        public ActionResult<int> Add(AddItems addItems)
        {
            int result=0;
            result = addItems.item1 + addItems.item2;
            return result;
        }
    }
}
