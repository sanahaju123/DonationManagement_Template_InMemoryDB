using Donation_Management.BusinessLayer.Interfaces;
using Donation_Management.BusinessLayer.ViewModels;
using Donation_Management.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;

namespace Donation_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NgoController : ControllerBase
    {
        private readonly INgoServices _ngoServices;
        private readonly IDonationRequestServices _donationRequestServices;
        public NgoController(INgoServices ngoServices, IDonationRequestServices donationRequestServices)
        {
            _ngoServices = ngoServices;
            _donationRequestServices = donationRequestServices;
        }

        #region NgoRegion
        /// <summary>
        /// Register a new NGO
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ngos/register-ngo")]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([FromBody] RegisterNgoViewModel model)
        {
            throw new NotImplementedException();

        }

        /// <summary>
        /// Update a existing NGO
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("ngos/update-ngo")]
        public async Task<IActionResult> UpdateNgo([FromBody] RegisterNgoViewModel model)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a existing NGO
        /// </summary>
        /// <param name="NgoId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("ngos/delete-ngo/{NgoId}")]
        public async Task<IActionResult> DeletNgo(long NgoId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get NGO by Id
        /// </summary>
        /// <param name="NgoId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ngos/get/{NgoId}")]
        public async Task<IActionResult> GetNgoById(long NgoId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// List All Ngos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ngos/all")]
        public async Task<IEnumerable<NgoDetails>> ListAllNgos()
        {
            throw new NotImplementedException();
        }
        #endregion


        #region DonationRequestRegion
        /// <summary>
        /// Create a new Donation Request
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ngos/create-donation-request")]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromBody] RegisterDonationRequestViewModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Donation Request by Ngo Id
        /// </summary>
        /// <param name="NgoId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ngos/donation-request-by-ngo/{NgoId}")]
        public async Task<IActionResult> GetDonationRequestByNgoId(long NgoId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Donation Request By Donor Id
        /// </summary>
        /// <param name="donorId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ngos/donation-request-by-donor/{donorId}")] 
        public async Task<IEnumerable<DonationRequest>> GetDonationRequestForDonorId(long donorId)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}