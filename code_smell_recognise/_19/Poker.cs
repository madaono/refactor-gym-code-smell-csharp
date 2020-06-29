using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace code_smell_recognise._19
{
    public class Poker
    {
        public string CompairResult(string black, string white)
        {
            var winResult = "";
            var blackType = JudgeType(black);
            var whiteType = JudgeType(white);
            string[] type =
            {
                "StraightFlush", "FourOfAKind", "FullHouse", "Flush", "Straight", "ThreeOfAKind", "TwoPair", "OnePair",
                "HighCard"
            };
            var blackNumber = StrNumber(black);
            var whiteNumber = StrNumber(white);
            var blackIndex = JudgeIndex(blackType);
            var whiteIndex = JudgeIndex(whiteType);
            var blackArraySort = ArraySort(blackNumber);
            var whiteArraySort = ArraySort(whiteNumber);
            var blackRepeat = NoOrRepeatNumber(blackNumber, 0);
            var whiteRepeat = NoOrRepeatNumber(whiteNumber, 0);
            var blackNoRepeat = NoOrRepeatNumber(blackNumber, 1);
            var whiteNoRepeat = NoOrRepeatNumber(whiteNumber, 1);
            if (blackIndex < whiteIndex)
            {
                winResult = "black wins - " + type[blackIndex];
            }
            else if (blackIndex > whiteIndex)
            {
                winResult = "white wins - " + type[whiteIndex];
            }
            else
            {
                if (blackIndex == 0)
                {
                    //同花顺
                    if (blackNumber[0] < whiteNumber[0])
                    {
                        var sig = IntNumber(whiteNumber[0]);
                        winResult = "white wins - high card:" + sig;
                    }
                    else if (blackNumber[0] > whiteNumber[0])
                    {
                        var sig = IntNumber(blackNumber[0]);
                        winResult = "black wins - high card:" + sig;
                    }
                    else
                    {
                        winResult = "tie";
                    }
                }
                else if (blackIndex == 1)
                {
                    //铁支
                    if (blackArraySort[0] < whiteArraySort[0])
                    {
                        var sig = IntNumber(whiteArraySort[0]);
                        winResult = "white wins - high card:" + sig;
                    }
                    else
                    {
                        var sig = IntNumber(blackArraySort[0]);
                        winResult = "black wins - high card:" + sig;
                    }
                }
                else if (blackIndex == 2)
                {
                    //葫芦
                    if (blackArraySort[0] < whiteArraySort[0])
                    {
                        var sig = IntNumber(whiteArraySort[0]);
                        winResult = "white wins - high card:" + sig;
                    }
                    else
                    {
                        var sig = IntNumber(blackArraySort[0]);
                        winResult = "black wins - high card:" + sig;
                    }
                }
                else if (blackIndex == 3)
                {
                    //同花
                    for (var i = 0; i < 5; i++)
                    {
                        if (blackNumber[i] < whiteNumber[i])
                        {
                            var sig = IntNumber(whiteNumber[i]);
                            winResult = "white wins - high card:" + sig;
                            break;
                        }
                        else if (blackNumber[i] > whiteNumber[i])
                        {
                            var sig = IntNumber(blackNumber[i]);
                            winResult = "black wins - high card:" + sig;
                            break;
                        }
                        else
                        {
                            winResult = "tie";
                        }
                    }
                }
                else if (blackIndex == 4)
                {
                    //顺子
                    if (blackNumber[0] < whiteNumber[0])
                    {
                        var sig = IntNumber(whiteNumber[0]);
                        winResult = "white wins - high card:" + sig;
                    }
                    else if (blackNumber[0] > whiteNumber[0])
                    {
                        var sig = IntNumber(blackNumber[0]);
                        winResult = "black wins - high card:" + sig;
                    }
                    else
                    {
                        winResult = "tie";
                    }
                }
                else if (blackIndex == 5)
                {
                    //三条
                    if (blackRepeat[0] < whiteRepeat[0])
                    {
                        var sig = IntNumber(whiteRepeat[0]);
                        winResult = "white wins - high card:" + sig;
                    }
                    else
                    {
                        string sig = IntNumber(blackRepeat[0]);
                        winResult = "black wins - high card:" + sig;
                    }
                }
                else if (blackIndex == 6)
                {
                    //两对
                    for (var i = 0; i < 2; i++)
                    {
                        if (blackRepeat[i] < whiteRepeat[i])
                        {
                            var sig = IntNumber(whiteRepeat[i]);
                            winResult = "white wins - high card:" + sig;
                            break;
                        }
                        else if (blackRepeat[i] > whiteNoRepeat[i])
                        {
                            var sig = IntNumber(blackRepeat[i]);
                            winResult = "black wins - high card:" + sig;
                            break;
                        }
                    }

                    if (winResult == "")
                    {
                        if (blackNoRepeat[0] < whiteNoRepeat[0])
                        {
                            var sig = IntNumber(whiteNoRepeat[0]);
                            winResult = "white wins - high card:" + sig;
                        }
                        else if (blackNoRepeat[0] > whiteNoRepeat[0])
                        {
                            var sig = IntNumber(blackNoRepeat[0]);
                            winResult = "black wins - high card:" + sig;
                        }
                        else
                        {
                            winResult = "tie";
                        }
                    }
                }
                else if (blackIndex == 7)
                {
                    //对子
                    if (blackRepeat[0] < whiteRepeat[0])
                    {
                        var sig = IntNumber(whiteRepeat[0]);
                        winResult = "white wins - high card:" + sig;
                    }
                    else if (blackRepeat[0] > whiteRepeat[0])
                    {
                        var sig = IntNumber(blackRepeat[0]);
                        winResult = "black wins - high card:" + sig;
                    }
                    else
                    {
                        for (var i = 0; i < 3; i++)
                        {
                            if (blackNoRepeat[i] < whiteNoRepeat[i])
                            {
                                var sig = IntNumber(whiteNoRepeat[i]);
                                winResult = "white wins - high card:" + sig;
                                break;
                            }
                            else if (blackNoRepeat[i] > whiteNoRepeat[i])
                            {
                                var sig = IntNumber(blackNoRepeat[i]);
                                winResult = "black wins - high card:" + sig;
                                break;
                            }
                            else
                            {
                                winResult = "tie";
                            }
                        }
                    }
                }
                else
                {
                    //散牌
                    for (var i = 0; i < 5; i++)
                    {
                        if (blackNumber[i] < whiteNumber[i])
                        {
                            var sig = IntNumber(whiteNumber[i]);
                            winResult = "white wins - high card:" + sig;
                            break;
                        }
                        else if (blackNumber[i] > whiteNumber[i])
                        {
                            var sig = IntNumber(blackNumber[i]);
                            winResult = "black wins - high card:" + sig;
                            break;
                        }
                        else
                        {
                            winResult = "tie";
                        }
                    }
                }
            }

            return winResult;
        }

        private string IntNumber(int i)
        {
            string[] strNumber = {"2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A"};
            return strNumber[i - 2];
        }

        private int[] ArraySort(int[] number)
        {
            var map = new Dictionary<int, int>();
            int i;
            for (i = 0; i < number.Length; i++)
            {
                if (map.TryGetValue(number[i], out var v))
                {
                    map.Add(number[i], v + 1);
                }
                else
                {
                    map.Add(number[i], 1);
                }
            }

            var sortedSet = map.ToImmutableSortedSet(Comparer<KeyValuePair<int, int>>.Create((k1, k2) => k1.Value.CompareTo(k2.Value)));
            
            var arrayresult = new int[sortedSet.Count];
            i = 0;
            foreach (var entry in sortedSet)
            {
                arrayresult[i] = entry.Key;
                i++;
            }
            return arrayresult;
        }

        private int[] NoOrRepeatNumber(int[] number, int flag)
        {
            //先获得数组中每个元素出现的次数，然后再进行计算出现次数大于1的和出现次数等于1的
            var dictionary = new Dictionary<int, int>();
            int i;
            for (i = 0; i < number.Length; i++)
            {
                if (dictionary.TryGetValue(number[i], out var v))
                {
                    dictionary.Add(number[i], v + 1);
                }
                else
                {
                    dictionary.Add(number[i], 1);
                }
            }

            var sortedSet = dictionary.ToImmutableSortedSet(Comparer<KeyValuePair<int, int>>.Create((k1, k2) => k1.Value.CompareTo(k2.Value)));

            var repeatnumber = new int[sortedSet.Count];
            var norepeatnumber = new int[sortedSet.Count];
            i = 0;
            if (flag == 0) {
                foreach (var item in sortedSet) {
                    if (item.Value > 1) {
                        repeatnumber[i] = item.Key;
                        i++;
                    }
                }
            } else {
                foreach (var item in sortedSet) {
                    if (item.Value == 1) {
                        norepeatnumber[i] = item.Key;
                        i++;
                    }
                }
            }

            var hashSet = new HashSet<int>();
            if (flag == 0)
            {
                for (i = 0; i < repeatnumber.Length; i++)
                {
                    hashSet.Add(repeatnumber[i]);
                }
            }
            else
            {
                for (i = 0; i < norepeatnumber.Length; i++)
                {
                    hashSet.Add(norepeatnumber[i]);
                }
            }

            hashSet.Remove(0);
            var result = new int[hashSet.Count];
            i = 0;
            using var enumerator = hashSet.GetEnumerator();
            while (enumerator.MoveNext())
            {
                result[i] = enumerator.Current;
                i++;
            }

            var reResult = new int[result.Length];
            for (i = 0; i < result.Length; i++)
            {
                reResult[i] = result[result.Length - i - 1];
            }

            return reResult;
        }

        private int JudgeIndex(String strType)
        {
            var index = -1;
            string[] type =
            {
                "StraightFlush", "FourOfAKind", "FullHouse", "Flush", "Straight", "ThreeOfAKind", "TwoPair", "OnePair",
                "HighCard"
            };
            for (int i = 0; i < 9; i++)
            {
                if (type[i] == strType)
                {
                    index = i;
                }
            }

            return index;
        }

        private string JudgeType(String str)
        {
            //判断是什么牌
            var type = "";
            var strArray = str.Split("");
            var number = StrNumber(str);
            int i;
            var color = new string[5];
            for (i = 0; i < 5; i++)
            {
                color[i] = strArray[i * 3 + 1];
            }

            var hashSetNumber = new HashSet<int>();
            for (i = 0; i < 5; i++)
            {
                hashSetNumber.Add(number[i]);
            }

            var hashSetType = new HashSet<string>();
            for (i = 0; i < 5; i++)
            {
                hashSetType.Add(color[i]);
            }

            if (hashSetNumber.Count == 5)
            {
                if ((number[0] - number[4] == 4) && (hashSetType.Count == 1) && (hashSetNumber.Count == 5))
                {
                    //五个相邻的数字且花色一样——同花顺
                    type = "StraightFlush";
                }
                else if (number[0] - number[4] == 4 && (hashSetNumber.Count == 5))
                {
                    //五个相邻数字——顺子
                    type = "Straight";
                }
                else if (hashSetType.Count == 1)
                {
                    //同一花色——同花
                    type = "Flush";
                }
                else
                {
                    //五个不相邻的数字——散牌
                    type = "HighCard";
                }
            }
            else if (hashSetNumber.Count == 4)
            {
                //一对相同，其余三个数字不同——对子
                type = "OnePair";
            }
            else if (hashSetNumber.Count == 3)
            {
                if ((number[0] == number[1] && number[2] == number[3]) ||
                    (number[1] == number[2] && number[3] == number[4]) ||
                    (number[0] == number[1] && number[3] == number[4]))
                {
                    //两对
                    type = "TwoPair";
                }
                else
                {
                    //三个数字相同，另外两个数字不同——三条
                    type = "ThreeOfAKind";
                }
            }
            else
            {
                if (number[0] != number[1] || number[3] != number[4])
                {
                    //三个数字相同，另外两个数字相同——葫芦
                    type = "FourOfAKind";
                }
                else
                {
                    //四个数字相同——铁支
                    type = "FullHouse";
                }
            }

            return type;
        }

        private int[] StrNumber(string str)
        {
            //数字转化并将其从大到小排序
            var number = new int[5];
            var strArray = str.Split("");
            int i;
            for (i = 0; i < 5; i++)
            {
                var c = strArray[i * 3];
                switch (c)
                {
                    case "T":
                        number[i] = 10;
                        break;
                    case "J":
                        number[i] = 11;
                        break;
                    case "Q":
                        number[i] = 12;
                        break;
                    case "K":
                        number[i] = 13;
                        break;
                    case "A":
                        number[i] = 14;
                        break;
                    default:
                        number[i] = Convert.ToInt32(c);
                        break;
                }
            }

            Array.Sort(number);
            var renumber = new int[number.Length];
            for (i = 0; i < number.Length; i++)
            {
                renumber[i] = number[number.Length - i - 1];
            }

            return renumber;
        }
    }
}