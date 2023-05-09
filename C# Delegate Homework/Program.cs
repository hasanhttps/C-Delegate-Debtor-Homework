using System.Diagnostics.Metrics;
using static Delegate.models.Debtor;
using System.Linq;
using Delegate.models;
using System.Numerics;
using System.Threading.Channels;
using System.Drawing;

namespace Delegate {
    internal class Program {
        static void Main() {

            // 2) rhyta.com ve ya dayrep.com domenlerinde emaili olan borclulari cixartmag

            // debtors.ForEach(debtor => { if (debtor.Email.Contains("rhyta.com") || debtor.Email.Contains("dayrep.com")) Console.WriteLine(debtor); });

            // 3) Yashi 26 - dan 36 - ya qeder olan borclulari cixartmag

            // debtors.ForEach(debtor => { if (2023 - debtor.BirthDay.Year > 26 && 2023 - debtor.BirthDay.Year < 36) Console.WriteLine(debtor); });

            // 4) Borcu 5000 - den cox olmayan borclularic cixartmag

            // debtors.ForEach(debtor => { if (debtor.Debt < 5000) Console.WriteLine(debtor); });

            // 5) Butov adi 18 simvoldan cox olan ve telefon nomresinde 2 ve ya 2-den cox 7 reqemi olan borclulari cixartmaq

            // debtors.ForEach(debtor => { 
            //     if (debtor.FullName.Length > 18 && debtor.Phone.Count(f => (f == '2')) < debtor.Phone.Count(f => (f == '7')) || 
            //     debtor.Phone.Contains("2")) 
            //         Console.WriteLine(debtor); 
            // });

            // 7) Qishda anadan olan borclulari cixardmaq

            // debtors.ForEach(debtor => {
            //     if (debtor.BirthDay.Month == 12 || debtor.BirthDay.Month == 1 ||
            //     debtor.BirthDay.Month == 2)
            //         Console.WriteLine(debtor);
            // });

            // 8) Borcu, umumi borclarin orta borcunnan cox olan borclulari cixarmaq ve evvel familyaya gore sonra ise meblegin azalmagina gore sortirovka etmek

            //int debtSum = 0;
            //debtors.ForEach(debtor => debtSum += debtor.Debt);
            //int avgDebt = debtSum / debtors.Count();
            //Console.WriteLine($"Avarage Debt : {avgDebt}");

            //debtors.Sort((d1, d2) => d1.FullName.Substring(d1.FullName.LastIndexOf(' ')).CompareTo(d2.FullName.Substring(d2.FullName.LastIndexOf(' '))));
            //debtors.Sort((d1, d2) => d2.Debt.CompareTo(d1.Debt));
            //debtors.ForEach(delegate (Debtor debt) { if (debt.Debt > avgDebt) Console.WriteLine(debt); });

            // 11)Adinda ve familyasinda hec olmasa 3 eyni herf olan borclularin siyahisin cixarmaq ve onlari elifba sirasina gore sortirovka elemek

            // debtors.Sort((d1, d2) => d1.FullName.CompareTo(d2.FullName));
            // debtors.ForEach(delegate (Debtor debtor) {
            //     string myString = debtor.FullName;
            //     Dictionary<char, int> charCounts = new Dictionary<char, int>();
            //     int maxCount = 0;

            //     foreach (char c in myString) {
            //         if (charCounts.ContainsKey(c)) {
            //             charCounts[c]++;
            //             if (charCounts[c] > maxCount) {  maxCount = charCounts[c]; }
            //         } else {
            //             charCounts.Add(c, 1);
            //         }
            //     }

            //     if (maxCount >= 3) Console.WriteLine(debtor);
            // });

            // 13) borclulardan en coxu hansi ilde dogulubsa hemin ili cixartmaq

            // var mostCommon = debtors.GroupBy(x => x.BirthDay.Year).OrderByDescending(x => x.Count())
            //            .First()
            //            .Key;

            // Console.WriteLine(mostCommon);

            // 14)Borcu en boyuk olan 5 borclunun siyahisini cixartmaq

            // debtors.Sort((d1, d2) => d2.Debt.CompareTo(d1.Debt));
            // for(int i = 0; i < 5; i++) {
            //     Console.WriteLine(debtors[i]);
            // }

            // 15)Butun borcu olanlarin borcunu cemleyib umumi borcu cixartmaq

            // int sum = 0;
            // debtors.ForEach(debtor => { sum += debtor.Debt; });

            // 16)2ci dunya muharibesin gormush borclularin siyahisi cixartmaq

            // debtors.ForEach((debtor) => {  if (debtor.BirthDay.Year <= 1945) Console.WriteLine(debtor); });

            // 18)Nomresinde tekrar reqemler olmayan borclularin ve onlarin borcunun meblegin cixartmaq

            // debtors.ForEach(delegate (Debtor debtor) {
            //     string myString = debtor.Phone;
            //     Dictionary<char, int> charCounts = new Dictionary<char, int>();
            //     int maxCount = 0;

            //     foreach (char c in myString) {
            //         if (c != '-') {
            //             if (charCounts.ContainsKey(c)) {
            //                charCounts[c]++;
            //                if (charCounts[c] > maxCount) {  maxCount = charCounts[c]; }
            //             } else {
            //                 charCounts.Add(c, 1);
            //             }
            //         }
            //     }

            //     if (maxCount == 0) Console.WriteLine(debtor);
            // });

            // 19) Tesevvur edek ki,butun borclari olanlar bugunden etibaren her ay 500 azn pul odeyecekler.
            // Oz ad gunune kimi borcun oduyub qurtara bilenlerin siyahisin cixartmaq

            // int currentMonth = 5, month = 0;
            // debtors.ForEach(debtor => {
            //     if (debtor.BirthDay.Month > currentMonth) { month = debtor.BirthDay.Month - currentMonth; }
            //     else month = 12 - (currentMonth - debtor.BirthDay.Month);
            //     if (debtor.Debt - (500 * month) <= 0) { Console.WriteLine(debtor); }
            // });

            // 20)Adindaki ve familyasindaki herflerden "smile" sozunu yaza bileceyimiz borclularin siyahisini cixartmaq

            debtors.ForEach(debtor => {
                if (debtor.FullName.Contains('s') && debtor.FullName.Contains('m') &&
                debtor.FullName.Contains('i') && debtor.FullName.Contains('l') && 
                debtor.FullName.Contains('e')) {
                    Console.WriteLine(debtor); 
                }
            });
        }
    }
}