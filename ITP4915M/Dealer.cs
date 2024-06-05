namespace ITP4915M
{
    class Dealer
    {
        private string _dealerCode;
        private string _dealerName;
        private string _dealerAddress;
        private string _dealerTel;

        public Dealer()
        {
            // 无参数构造函数的实现
        }

        public Dealer(string dealerCode, string dealerName, string dealerAddress, string dealerTel)
        {
            DealerCode = dealerCode;
            DealerName = dealerName;
            DealerAddress = dealerAddress;
            DealerTel = dealerTel;
        }

        public string DealerCode
        {
            get { return _dealerCode; }
            set { _dealerCode = value; }
        }

        public string DealerName
        {
            get { return _dealerName; }
            set { _dealerName = value; }
        }

        public string DealerAddress
        {
            get { return _dealerAddress; }
            set { _dealerAddress = value; }
        }

        public string DealerTel
        {
            get { return _dealerTel; }
            set { _dealerTel = value; }
        }
    }
}