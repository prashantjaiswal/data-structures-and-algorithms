﻿using System;
using System.Collections.Generic;
using DataStructuresAlgorithms.Practice;
using Xunit;

namespace Test_Data_Structure_Algorithms.Practice
{
    public class TestPractice
    {
        [Fact]
        public void TestReverseArrayOperation()
        {
            Practice01 practice = new Practice01();
          
            int param = int.MaxValue;
            //int result = practice.SquareRoot(param);
            //Assert.Equal(-1, result);

            param = 829702;
            int result = practice.SquareRoot(param);
            Assert.Equal(10000, result);

            param = 16;
            result = practice.SquareRoot(param);
            Assert.Equal(4, result);

            //100000000
        }

        [Fact]
        public void TestIsItPrime()
        {
            Practice01 practice = new Practice01();

            int param = 829702;
            int result = practice.SquareRoot(param);
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestIsPerfectNumber()
        {
            Practice01 practice = new Practice01();

            var result = practice.IsPerfectNumber(4);
            Assert.Equal("NO", result);

            result = practice.IsPerfectNumber(8129);
            Assert.Equal("NO", result);

            result = practice.IsPerfectNumber(6);
            Assert.Equal("YES", result);

            result = practice.IsPerfectNumber(496);
            Assert.Equal("YES", result);

            result = practice.IsPerfectNumber(8128);
            Assert.Equal("YES", result); 
        }

        [Fact]
        public void TestFindAllArmstrongNumber()
        {
            Practice01 practice = new Practice01();

            int param = 200;
            var result = practice.FindAllArmstrongNumber(param);
            result = practice.FindAllArmstrongNumberOrderNForThreeDigit(param);
        }

        [Fact]
        public void TestTable()
        {
            Practice01 practice = new Practice01();

            int param = 200;
            practice.CreateTable(param);
        }

        [Fact]
        public void TestSolveMaxMod()
        {
            Practice01 practice = new Practice01();
            var t = practice.SolveMaxMod(new List<int> { 1, 2, 44, 3 });
            Assert.Equal(3, t);

            t = practice.SolveMaxMod(new List<int> { 2, 6, 4 });
            Assert.Equal(4, t);

             t = practice.SolveMaxMod01(new List<int> { 1, 2, 44, 3 });
            Assert.Equal(3, t);

            t = practice.SolveMaxMod01(new List<int> { 2, 6, 4 });
            Assert.Equal(4, t);
        }

        [Fact]
        public void TestComplexity()
        {
            Practice01 practice = new Practice01();
            var t = practice.TimeComplexity(10);
            Assert.Equal(t, t);
        }

        [Fact]
        public void TestFindSecondHighest()
        {
            Practice01 practice = new Practice01();
            var t = practice.FindSecondHighest(new List<int> { 699052608, 735148890, 290332454, 317332564, 82022478, 289200399, 891239093, 226711949, 522100630, 803767529, 453767697, 567678483, 656384860, 225726628, 97026272, 855085618, 806283393, 756306881, 983086733, 789703213, 946391085, 957073782, 274429741, 2237753, 380666322, 255688130, 633400156, 716495667, 321038171, 608900703, 549290512, 446618032, 245097105, 330821177, 989447591, 890244188, 65265250, 254768130, 177390364, 865997351, 501736283, 607717367, 282860408, 562380596, 639595018, 903747637, 931619784, 908564804, 94178401, 252988413, 887294432, 597987502, 878735085, 522211649, 93867264, 195206281, 22051436, 577724806, 353265201, 291054967, 698513378, 586464717, 624813876, 79244042, 179661943, 870136409, 351934186, 177151411, 366232618, 137427549, 173423769, 985253209, 496082913, 111915386, 332222339, 415174458, 260274641, 332420005, 957977269, 615638346, 456393377, 630694241, 572584128, 309098451, 255277824, 754838980, 473471641, 61858234, 280497232, 666420178, 25932928, 729382255, 249521217, 715462621, 512644224, 182587998, 509983113, 618663429, 236351942, 538979817, 911571363, 555632136, 278177476, 226025048, 652234602, 958542148, 253663792, 527586691, 624165536, 60659092, 865484277, 660988917, 491709703, 74435789, 512788694, 743853170, 867120545, 953013023, 225436648, 917757297, 993926180, 480918188, 448717446, 697162775, 930325644, 901939719, 20580891, 123090390, 889714492, 951187597, 666279091, 362144725, 306920018, 402557398, 440177925, 269987198, 19442043, 327210549, 374649166, 277684770, 583754111, 942928252, 364024587, 319389154, 443276119, 712268314, 585834713, 255661565, 979632628, 813218027, 756840870, 51870739, 10342203, 374101694, 662274672, 466941606, 342180166, 204030989, 519484522, 843081089, 951632576, 931312379, 156018860, 456247729, 818640201, 39262266, 758319195, 417759275, 307157250, 515483363, 554876143, 562619826, 7401575, 232744042, 327414130, 722581198, 153036637, 854763529, 549943882, 237645670, 437548289, 633965955, 241873853, 484303888, 566327508, 333688197, 224254807, 289866874, 30038646, 885240648, 914123523, 954780282, 430052676, 291510729, 776605801, 569058823, 360698573, 218329417, 628691297, 712568953, 531907100, 83447593, 903517615, 824730578, 279160911, 237079730, 404668780, 477588313, 524916943, 489254849, 385885845, 996495569, 261438875, 914066733, 646260436, 865540060, 402136744, 6702050, 639126852, 947767848, 759161735, 867555341, 378598164, 899686446, 868522476, 983510331, 575828929, 432486551, 573177766, 475653577, 610682819, 824858508, 534437623, 833263791, 716489476, 529766622, 410529327, 29726907, 500226837, 283239304, 686878209, 668592244, 896924628, 95563918, 345424302, 187851163, 269783210, 68942174, 382062593, 23037513, 15503422, 574049548, 483741493, 81593541, 366207605, 903370387, 909008014, 104261879, 213901291, 374015906, 236942014, 322332432, 19248845, 839425505, 138160259, 418009993, 746038181, 576738335, 65864716, 189919985, 291942662, 106638871, 131747741, 621635740, 390765002, 97280929, 748192449, 722851989, 30009086, 928214193, 549337018, 920404911, 589318879, 786413402, 643471809, 176126410, 958070725, 8146019, 763306869, 979097651, 838571679, 211647684, 7451029, 267280263, 280300891, 369836377, 477639317, 476574035, 410318522, 53978985, 589028433, 658723848, 752416713, 719924689, 262788225, 841179292, 695976001, 52284204, 602897467, 651341305, 389264336, 520690590, 700166463, 588509232, 989284677, 697553902, 289301178, 318462420, 33484900, 438608801, 745331507, 580953595, 133567729, 505907989, 450259456, 650299813, 404931165, 483316477, 733975837, 325370482, 620760326, 852832761, 165580230, 847519630, 462950101, 28940192, 392061239, 523956975, 149187139, 735689289, 934111645, 643592371, 927975414, 847221244, 316789475, 804474787, 932133848, 241305866, 93351191, 513295443, 151178814, 853715522, 599697580, 941973048, 74591499, 116268341, 466738457, 448906957, 88640772, 65463351, 268177049, 494205304, 767351374, 630913262, 917384806, 897467789, 91097900, 935555449, 90229511, 80330610, 34957778, 37880648, 410017508, 925726130, 714699577, 70047648, 870518275, 752277247, 114902906, 915355030, 138878966, 41882667, 154632880, 379453721, 360880762, 613588409, 670110998, 452450965, 767387334, 142911455, 27907912, 814323569, 556698219, 503753834, 464804071, 703624793, 848562021, 113742853, 781513307, 887694672, 889954549, 508544222, 434756811, 665795227, 928470564, 588783534, 190197630, 688737298, 650603541, 575049664, 238407069, 290401425, 910712892, 349321256, 761605692, 610672314, 316311712, 478532942, 909708957, 139765465, 198992121, 822077967, 447355603, 548025902, 350139762, 156774037, 990425296, 216366034, 199038321, 265650365, 7446894, 845429947, 647316490, 47992190, 885178653, 321303173, 151163867, 610142770, 598625181, 992777571, 621081744, 719626808, 411432484, 575484900, 33446711 });
            Assert.Equal(993926180, t);

            t = practice.FindSecondHighest(new List<int> { 2, 1, 2});
            Assert.Equal(2, t);

            t = practice.FindSecondHighest(new List<int> { 2 });
            Assert.Equal(-1, t);

            t = practice.FindSecondHighest(new List<int> { 2 , 1, 3, 4 });
            Assert.Equal(3, t);
        }
    }
}
