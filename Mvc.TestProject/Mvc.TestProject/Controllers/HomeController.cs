using Mvc.TestProject.Data;
using Mvc.TestProject.Data;
using Mvc.TestProject.Domain;
using Mvc.TestProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;


namespace Mvc.TestProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<Contact> _ContactRepository = null;

        public  HomeController(IRepository<Contact> contactRepository)
        {
            _ContactRepository = contactRepository;

            Mapper.CreateMap<ContactModel, Contact>()
                .ForMember(src=>src.FirstName,opt=>opt.MapFrom(src=>src.FirstName))
                .ForMember(src=>src.LastName,opt=>opt.MapFrom(src=>src.LastName));
            Mapper.CreateMap<AddressModel, Address>()
                .ForMember(src => src.Line1, opt => opt.MapFrom(src => src.Line1))
                .ForMember(src => src.City, opt => opt.MapFrom(src => src.City));

            Mapper.CreateMap<ContactAddressVM, Contact>()
                .ForMember(src => src.FirstName, opt => opt.MapFrom(src => src.ContactVM.FirstName))
                .ForMember(src => src.LastName, opt => opt.MapFrom(src => src.ContactVM.LastName))
                .ForMember(src => src.Addresses, opt => opt.MapFrom(src => src.Addresses));

        }

        public ActionResult Index()
        {

            var list = _ContactRepository.GetAll().ToList<Contact>();

            return View(list);
        }
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.Message = "Your app description page.";

            return View(new ContactAddressVM());
        }

        [HttpPost]
        public ActionResult Create(ContactAddressVM newContanct)
        {
            
            _ContactRepository.Add(Mapper.Map<Contact>(newContanct));
            _ContactRepository.SaveChanges();
             
            return View(new ContactAddressVM()); 
        }

      
    }
}
