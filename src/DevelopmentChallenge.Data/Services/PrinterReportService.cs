using System.Collections.Generic;
using System.Linq;
using DevelopmentChallenge.Data.Domain;

namespace DevelopmentChallenge.Data.Services
{
    public class PrinterReportService
    {
        private ILanguageManager _languageManager { get; }
        public PrinterReportService(ILanguageManager languageLanguageManager)
        {
            _languageManager = languageLanguageManager;
        }
        
        public string Print(IList<GeometricShape> shapes)
        {
            var report = new ReportBuilder();

            if (!shapes.Any())
            {
                report.AddEmptyResult(GetEmptyResult());
            }
            else
            {
                var shapeGroups = shapes
                    .GroupBy(shape => shape.ShapeType)
                    .Select(group =>
                        new ShapeGroupDto(
                            group.Key,
                            group.Sum(s => s.Perimeter),
                            group.Sum(s => s.Area),
                            group.Count())
                    ).ToList();

                var shapeSections = shapeGroups
                    .Select(GetShapeSection)
                    .ToList();

                report.AddTitle(GetTitle())
                    .AddShapeSections(shapeSections)
                    .AddFooter(GetFooter(shapeGroups));
            }

            return report.Build();
        }
        
        private string GetFooter(List<ShapeGroupDto> shapeGroups)
        {
            return string.Format(@"{0}:<br/>{1} {2} {3} {4:#.##} {5} {6:#.##}", 
                GetTotalLabel(),
                shapeGroups.Sum(g => g.ShapeCount),
                GetShapeLabel(),
                GetPerimeterLabel(), shapeGroups.Sum(g => g.PerimeterSum),
                GetAreaLabel(), shapeGroups.Sum(g => g.AreaSum));
        }

        private string GetShapeSection(ShapeGroupDto shapeGroupDto)
        {
            return string.Format(@"{0} {1} | {2} {3:#.##} | {4} {5:#.##} <br/>", 
                shapeGroupDto.ShapeCount, 
                GetShapeType(shapeGroupDto.ShapeType, shapeGroupDto.ShapeCount > 1), 
                GetAreaLabel(), shapeGroupDto.AreaSum,
                GetPerimeterLabel(), shapeGroupDto.PerimeterSum);
        }

        private string GetTitle()
        {
            return $"<h1>{_languageManager.GetLabel("REPORT_TITLE")}</h1>";
        }

        private string GetEmptyResult()
        {
            return $"<h1>{_languageManager.GetLabel("EMPTY_SHAPES_RESULT")}</h1>";
        }

        private string GetShapeType(string shapeType, bool isPlural)
        {
            return _languageManager.GetEntity(shapeType, isPlural);
        }

        private string GetAreaLabel()
        {
            return _languageManager.GetLabel("SHAPE_AREA");
        }

        private string GetPerimeterLabel()
        {
            return _languageManager.GetLabel("SHAPE_PERIMETER");
        }

        private string GetTotalLabel()
        {
            return _languageManager.GetLabel("TOTAL");
        }

        private string GetShapeLabel()
        {
            return _languageManager.GetLabel("SHAPES");
        }
    }
}
