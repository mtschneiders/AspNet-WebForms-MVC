using Entity;
using Grid.Mvc.Ajax.GridExtensions;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class CustomerController : ApplicationController
    {
        private GridMvcHelper gridMvcHelper;

        public CustomerController()
        {
            gridMvcHelper = new GridMvcHelper();
        }

        private List<Customer> Customers
        {
            get
            {
                if (Session["Customers"] == null)
                    Session["Customers"] = new List<Customer>();

                return Session["Customers"] as List<Customer>;
            }
        }
        
        // GET: Dummy
        public ActionResult Index()
        {
            return View(Customers);
        }

        public RedirectToRouteResult Add(Customer customer)
        {
            Customers.Add(customer);
            return RedirectToAction("Index");
        }


        private const string GRID_PARTIAL_PATH = "~/Views/Customer/_CustomerGrid.cshtml";

        [ChildActionOnly]
        public ActionResult GetGrid()
        {
            //var items = this.data.GetFootballers().OrderBy(f => f.FirstName);
            var grid = this.gridMvcHelper.GetAjaxGrid(Customers.AsQueryable().OrderBy(item => item.Name));

            return PartialView(GRID_PARTIAL_PATH, grid);
        }

        [HttpGet]
        public ActionResult GridPager(int? page)
        {
            var items = Customers.AsQueryable().OrderBy(item => item.Name);
            var grid = this.gridMvcHelper.GetAjaxGrid(items, page);
            object jsonData = this.gridMvcHelper.GetGridJsonData(grid, GRID_PARTIAL_PATH, this);

            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        public class GridMvcHelper
        {
            public AjaxGrid<T> GetAjaxGrid<T>(IOrderedQueryable<T> items) where T : class
            {
                return this.GetAjaxGrid(items, null);
            }

            public AjaxGrid<T> GetAjaxGrid<T>(IOrderedQueryable<T> items, int? page) where T : class
            {
                var ajaxGridFactory = new AjaxGridFactory();
                int pageValue = page.HasValue ? page.Value : 1;
                var grid = ajaxGridFactory.CreateAjaxGrid(items, pageValue, page.HasValue);
                var castGrid = (AjaxGrid<T>)grid;

                return castGrid;
            }

            public object GetGridJsonData<T>(AjaxGrid<T> grid, string gridPartialViewPath, Controller controller) where T : class
            {
                string html = grid.ToJson(gridPartialViewPath, controller);
                bool hasItems = grid.HasItems;
                object jsonData = new
                {
                    Html = html,
                    hasItems
                };

                return jsonData;
            }
        }
    }
}