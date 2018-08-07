using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgo
{
    class Class1
    {
        //
        //
        /* CAN FD 2.0B 64BYTE
         * 
         * [PROTOCOL]
         * CMD [1] - '0' : 상태 정보 C -> H : <1><R/W><D ID><FFFFFFFF OPEN><FFFFFFFF RISING><FFFFFFFF FALLING><FFFFFFFF DELAY><FFFF MAX VOLT><FFFF MINVOLT><FFF HI VT><FFF LO VT>
         *                 응답없음
         * 
         * CMD [1] - 'A' : 설정      C <- H : <1><D ID><FFFFFFFF OPEN><FFFFFFFF RISING><FFFFFFFF FALLING><FFFFFFFF DELAY><FFFF MAX VOLT><FFFF MINVOLT><FFF HI VT><FFF LO VT>
         *                 설정 응답 C <- H : <1><D ID><FFFFFFFF OPEN><FFFFFFFF RISING><FFFFFFFF FALLING><FFFFFFFF DELAY><FFFF MAX VOLT><FFFF MINVOLT><FFF HI VT><FFF LO VT>
         *                 
         * CMD 1[] - '1' : 운전 상태 C -> H : <1><R/W><D ID>
         *                 응답없음
         * 
         */
#if AAA
0000000001111111111222222222233333333334444444444555555555566666
1 2 3 45678901 23456789 01234567 89012345 6789 0123 456 789012345678901234
1,W,F,FFFFFFFF,FFFFFFFF,FFFFFFFF,FFFFFFFF,FFFF,FFFF,FFF,FFF

0000000001111111111222222222233333333334444444444555555555566666
1234567890123456789012345678901234567890123456789012345678901234
A,F,FFFFFFFF,FFFFFFFF,FFFFFFFF,FFFFFFFF,FFFF,FFFF,FFF,FFF

#endif

        /// <summary>
        /// 운전모드
        ///   0 - 대기
        ///   1 - 운전
        ///   2 - 설정
        /// </summary>
        private int g_running = 0;
        public void main()
        {

            InitDevice();

            while(true)
            {
                if (g_running == 1)
                    RunProcess();
                else
                    WaitProcess();
            }
        }

        private void InitDevice()
        {

        }

        private void RunProcess()
        {
            // 1. 0.5초 간격으로 CAN DATA 전송
        }


        private void WaitProcess()
        {
            // 1. 0.5초 간격으로 CAN DATA 전송
        }
    }
}
