using System.Collections.Generic;
using System.Text;

namespace DevelopmentChallenge.Data.Services
{
    public class ReportBuilder
    {
        private StringBuilder _builder { get; set; }
        public ReportBuilder()
        {
            _builder = new StringBuilder();
        }

        public ReportBuilder AddTitle(string title)
        {
            _builder.Append(title);
            return this;
        }

        public ReportBuilder AddEmptyResult(string empty)
        {
            _builder.Append(empty);
            return this;
        }

        public ReportBuilder AddShapeSections(List<string> sections)
        {
            sections.ForEach(s => AddShapeSection(s));
            return this;
        }

        public ReportBuilder AddShapeSection(string section)
        {
            _builder.Append(section);
            return this;
        }

        public ReportBuilder AddFooter(string footer)
        {
            _builder.Append(footer);
            return this;
        }
        public string Build()
        {
            return _builder.ToString();
        }
    }
}