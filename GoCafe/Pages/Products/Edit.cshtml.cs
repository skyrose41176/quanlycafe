using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Interfaces;
using ApplicationCore.DTOs;
using AutoMapper;
using GoCafe.Interfaces;
using GoCafe.ViewModels;

namespace GoCafe.Pages.Products
{
    public class EditProduct : PageModel
    {
        private readonly IProductService _context;
       private readonly ICategoryIndexVmService _categoryService;
        private readonly IMapper _mapper;
        public EditProduct(IProductService context, IMapper mapper,ICategoryIndexVmService categoryService)
        {
            _categoryService=categoryService;
            _mapper = mapper;
            _context = context;
        }
        public CategoryIndexVm CategoryIndexVM { get; set; }

        [BindProperty]
        public SaveProductDto Product { get; set; }
        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            CategoryIndexVM = _categoryService.GetCategoryListVm("","",1);
            var product = _context.GetProduct(id ?? default(int));

            if (product == null)
            {
                return NotFound();
            }
            Product = _mapper.Map<ProductDto,SaveProductDto>(product);

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                return Page();
            }
            try
            {
                _context.UpdateProduct(Product);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(Product.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProductExists(int id)
        {
            return _context.GetProduct(id) != null;
        }

        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("Username");
            HttpContext.Session.Remove("UserRole");
            HttpContext.Session.Remove("Fullname");
            return RedirectToPage("/Index");
        }
    }
}
