using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Interfaces;
using ApplicationCore.DTOs;
using AutoMapper;

namespace GoCafe.Pages.Categorys
{
    public class EditCategory : PageModel
    {
        private readonly ICategoryService _context;

        private readonly IMapper _mapper;
        public EditCategory(ICategoryService context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        [BindProperty]
        public SaveCategoryDto Category { get; set; }
        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = _context.GetCategory(id ?? default(int));

            if (category == null)
            {
                return NotFound();
            }
            Category = _mapper.Map<CategoryDto,SaveCategoryDto>(category);

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
                _context.UpdateCategory(Category);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(Category.CategoryId))
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

        private bool CategoryExists(int id)
        {
            return _context.GetCategory(id) != null;
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
