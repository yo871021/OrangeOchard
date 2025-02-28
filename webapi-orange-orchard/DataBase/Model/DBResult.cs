namespace DataBase.Model
{
    public class DBResult
    {
        public string? Message { get ; set ; }
        public string? Code { get; set ; }
        public bool IsSuccess { get => string.IsNullOrEmpty(Message); }
        public bool IsFail { get => !IsSuccess; }
        public int AffectCount { get; set; } = -1;
        public IEnumerable<object>? ListData { get; set; }

        private void ClearData()
        {
            ListData = null;
        }

        protected internal DBResult AssignMessage(string msg, string? code = null)
        {
            Message = msg;
            Code = code;

            ClearData();

            return this;
        }

        protected internal DBResult AssignException(Exception ex)
        {
            AssignMessage(ex.Message);

            return this;
        }
    }
}
