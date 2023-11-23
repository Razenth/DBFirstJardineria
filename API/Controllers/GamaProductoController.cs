using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Controllers;
using API.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Persistence.Data;

namespace API.Controller
//1. CarpetaApiNombre
//2. NombreEntidad
//3. Nombre en UnitOfWork, generalmente en plural
{
    public class GamaProductoController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly GardenContext _context;

        public GamaProductoController(IUnitOfWork unitOfWork, IMapper mapper, GardenContext context)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<GamaProductoDto>>> Get()
        {
            var nombreVariable = await _unitOfWork.GamaProductos.GetAllAsync();
            return _mapper.Map<List<GamaProductoDto>>(nombreVariable);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GamaProductoDto>> Get(int id)
        {
            var nombreVariable = await _unitOfWork.GamaProductos.GetByIdAsync(id);

            if (nombreVariable == null)
            {
                return NotFound();
            }

            return _mapper.Map<GamaProductoDto>(nombreVariable);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<GamaProducto>> Post(GamaProductoDto GamaProductoDto)
        {
            var nombreVariable = _mapper.Map<GamaProducto>(GamaProductoDto);
            this._unitOfWork.GamaProductos.Add(nombreVariable);
            await _unitOfWork.SaveAsync();

            if (nombreVariable == null)
            {
                return BadRequest();
            }
            GamaProductoDto.Id = nombreVariable.Id;
            return CreatedAtAction(nameof(Post), new { id = GamaProductoDto.Id }, GamaProductoDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GamaProductoDto>> Put(string id, [FromBody] GamaProductoDto GamaProductoDto)
        {
            if (GamaProductoDto.Id.Count() == 0)
            {
                GamaProductoDto.Id = id;
            }

            if(GamaProductoDto.Id != id)
            {
                return BadRequest();
            }

            if(GamaProductoDto == null)
            {
                return NotFound();
            }

             // Por si requiero la fecha actual
            /*if (GamaProductoDto.Fecha == DateTime.MinValue)
            {
                GamaProductoDto.Fecha = DateTime.Now;
            }*/

            var nombreVariable = _mapper.Map<GamaProducto>(GamaProductoDto);
            _unitOfWork.GamaProductos.Update(nombreVariable);
            await _unitOfWork.SaveAsync();
            return GamaProductoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var nombreVariable = await _unitOfWork.GamaProductos.GetByIdAsync(id);

            if (nombreVariable == null)
            {
                return NotFound();
            }

            _unitOfWork.GamaProductos.Remove(nombreVariable);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}