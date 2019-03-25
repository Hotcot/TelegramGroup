namespace ConsoleBd
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
  

    [Table("LogData")]
    public partial class LogData
    {
        public int Id { get; set; }

        public string LogMessage { get; set; }

        public TimeSpan StartProcessingTime { get; set; }

        public TimeSpan EndProcessingTime { get; set; }
    }
}
