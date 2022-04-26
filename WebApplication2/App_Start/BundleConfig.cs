using System.Web;
using System.Web.Optimization;

namespace WebApplication2
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

     


            bundles.Add(new StyleBundle("~/Content/css").Include(
                  "~/Scripts/plugins/fontawesome-free/css/all.min.css"
                 , "~/Scripts/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css"
                , "~/Scripts/plugins/icheck-bootstrap/icheck-bootstrap.min.css"
                , "~/Scripts/plugins/jqvmap/jqvmap.min.css"
                , "~/Scripts/dist/css/adminlte.min.css"
                , "~/Scripts/plugins/overlayScrollbars/css/OverlayScrollbars.min.css"
                , "~/Scripts/plugins/daterangepicker/daterangepicker.css"
                , "~/Scripts/plugins/summernote/summernote-bs4.min.css"));




                                          bundles.Add(new ScriptBundle("~/bundles/adminlte").Include(
                    "~/Scripts/plugins/jquery/jquery.min.js"
                    ,"~/Scripts/plugins/jquery-ui/jquery-ui.min.js"
                    ,"~/Scripts/plugins/bootstrap/js/bootstrap.bundle.min.js"
                    , "~/Scripts/plugins/chart.js/Chart.min.js"
                    , "~/Scripts/plugins/sparklines/sparkline.js"
                    , "~/Scripts/plugins/jqvmap/jquery.vmap.min.js"
                    , "~/Scripts/plugins/jqvmap/maps/jquery.vmap.usa.js"
                    , "~/Scripts/plugins/jquery-knob/jquery.knob.min.js"
                    , "~/Scripts/plugins/moment/moment.min.js"
                    , "~/Scripts/plugins/daterangepicker/daterangepicker.js"
                    , "~/Scripts/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js"
                    , "~/Scripts/plugins/summernote/summernote-bs4.min.js"
                    , "~/Scripts/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js"
                    , "~/Scripts/dist/js/adminlte.js"
                    , "~/Scripts/dist/js/demo.js"
                    , "~/Scripts/dist/js/pages/dashboard.js"));




        }
    }
}
