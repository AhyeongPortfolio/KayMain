using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayMain
{
    class SQLStatement
    {
        public static string
            SelectSQL = @"SELECT user_name, user_pswd, user_mst, user_stop, user_pswd_cnt FROM KAY_USER 
                            WHERE user_id = :user_id";

        public static string
            SelectSQL3 = @"SELECT pgm_id,pgm_name,pgm_kind1,pgm_kind2,pgm_dllname,pgm_pi,pgm_ver,pgm_width,pgm_height,pgm_maximize,
                            auth_pgmid,auth_all,auth_read,auth_insert,auth_update,auth_delete,auth_print,pgm_auth 
                           FROM KAY_PGM, KAY_AUTH
                           WHERE pgm_use = :pgm_use 
                             AND pgm_name LIKE :pgm_name
                             AND pgm_id = auth_pgmid(+) 
                             AND auth_userid(+) = :auth_userid
                           ORDER BY pgm_seq, pgm_kind1, pgm_kind2";

        public static string
            UpdateSQL = @"UPDATE kay_user SET
                           user_pswd_cnt = user_pswd_cnt + 1
                           ,user_pswd_ip = :ip
                           ,user_stop = :stop
                          Where user_id = :user_id
                           ";

        public static string
            UpdateSQL2 = @"UPDATE kay_user SET
                            user_pswd_cnt = 0
                            ,user_con_ip = :ip
                            ,user_lastcon = :lastcon
                            ,user_stop = 'N'
                           WHERE user_id = :user_id";

    }
}
