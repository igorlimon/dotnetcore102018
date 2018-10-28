using System;
using System.Collections.Generic;
using System.Linq;
using AgileHub102018.Models.Puppets;
using ListOperation;
using Microsoft.AspNetCore.Mvc;

namespace AgileHub102018.Controllers
{
    public class PuppetsController : Controller
    {
        private readonly IDataList _dataList;

        public PuppetsController(IDataList dataList)
        {
            _dataList = dataList;
        }

        public IActionResult Index()
        {
            return View(_dogs);
        }

        public IActionResult GetByName(string name)
        {
            return View("Index", _dogs.Where(dog => dog.Name.Contains(name, StringComparison.OrdinalIgnoreCase)));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var dog = _dogs.FirstOrDefault(d => d.Id == id);

            return View("_EditDog", dog);
        }

        [HttpPost]
        public IActionResult Edit(Dog dog)
        {
            int index = _dogs.FindIndex(d => d.Id == dog.Id);
            _dogs[index] = dog;

            return View("Index", _dogs);
        }
    }
}