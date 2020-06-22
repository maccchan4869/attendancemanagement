using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const
{
    public class Const
    {
        public class APPLY_CD
        {
            /// <summary>
            /// 休暇申請
            /// </summary>
            public const string VACATION = "01";

            /// <summary>
            /// 経費申請
            /// </summary>
            public const string EXPENSE = "02";
        }

        public class APPLY_STATUS
        {
            public class VACATION
            {
                /// <summary>
                /// 申請中
                /// </summary>
                public const string APPLYING = "01";

                /// <summary>
                /// 承認済み
                /// </summary>
                public const string APPROVED = "02";

                /// <summary>
                /// 取得済み
                /// </summary>
                public const string ACQUIRED = "03";

                /// <summary>
                /// 却下
                /// </summary>
                public const string REJECTED = "04";
            }

            public class EXPENSE
            {
                /// <summary>
                /// 申請中
                /// </summary>
                public const string APPLYING = "01";

                /// <summary>
                /// 承認済み
                /// </summary>
                public const string APPROVED = "02";

                /// <summary>
                /// 清算済み
                /// </summary>
                public const string LIQUIDATED = "03";

                /// <summary>
                /// 却下
                /// </summary>
                public const string REJECTED = "04";
            }
        }

        public class RESULT_CD
        {
            /// <summary>
            /// 成功
            /// </summary>
            public const string SUCCESS = "000";

            /// <summary>
            /// 失敗
            /// </summary>
            public const string FAILED = "999";
        }
    }
}
