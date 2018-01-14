using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace My_five_chess {
    class borad {
        private Point nullPoint = new Point(-1, -1);
        private static int offset = 65;
        private static int node_radius = 15;
        private static int node_distance = 55;

        public bool CanBePlaced(int x, int y) {
            //找出最近的節點
            Point nodeId = FindTheClosetNode(x, y);
            //如果沒有最近節點，return false
            if (nodeId == nullPoint) {
                return false;
            } else {
                return true;
            }
            //如果有最近節點判斷可否放棋子
            
        }
        //二維的判斷
        public Point FindTheClosetNode(int x, int y) {
            int nodeX = FindTheClosetNode(x);
            if (nodeX == -1) {
                return nullPoint;
            }
            int nodeY = FindTheClosetNode(y);
            if (nodeY == -1) {
                return nullPoint;
            }
            return new Point(nodeX, nodeY);
        }
        //一維的判斷
        private int FindTheClosetNode(int oneD) {
            oneD -= offset;
            int quotient = oneD / node_distance;
            int remainder = oneD % node_distance;
            if (remainder <= node_radius) {
                return quotient;
            } else if (remainder >= node_distance - node_radius) {
                return quotient + 1;
            } else {
                return -1;
            }
        }
    }
}
