using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace My_five_chess {
    class whoseWin { 
       
            
            //check the horizontal 
       public int winCheck(int who, int[,] table) {
            int black = 1, white = 2;  
            int blackSum = new int();
            int whiteSum = new int();
            //判斷丟進來的是誰
            if (who == black) blackSum = check(who, table);
            if (who == white) whiteSum = check(who, table);
            //回傳誰贏
            return (blackSum == 5) ? 1 : (whiteSum == 5)? 2 : 0;
        }

        //將複雜的演算法丟到另一個獨立的方法裡
        private int check (int who, int[,] table) {
            //為了要記數，製作四個向量，下、右、斜上、斜下
            int x = 0, y = 0, xyU = 0, xyD = 0;
            //掃描用陣列做的棋盤格，黑 = 1、白 = 2
            //如果掃描一次沒有五的，就換下一個一樣顏色的進行計算
            for (int a = 0; a < 15; a++) {
                for (int b = 0; b < 15; b++) {
                    x = 0; y = 0; xyD = 0; xyU = 0;
                    if (table[a, b] == who) {
                        //向四個向量掃描走五步並計算
                        for(int i = 0; i < 5; i++) {
                            if (a <= 9 && table[a + i, b] == who) x++;
                            if (b <= 9 && table[a, b + i] == who) y++;
                            if (a >= 4 && b <= 9 && table[a - i, b + i] == who) xyU++;
                            if (a <= 9 && b <= 9 && table[a + i, b + i] == who) xyD++;
                        }
                        if (x == 5 || y == 5 || xyU == 5 || xyD == 5) break;
                    }
                    if (x == 5 || y == 5 || xyU == 5 || xyD == 5) break;
                }
                if (x == 5 || y == 5 || xyU == 5 || xyD == 5) break;
            }
            return (x == 5) ? x : (y == 5) ? y : (xyU == 5) ? xyU : (xyD == 5) ? xyD : 0;
        }
           
    }
}
