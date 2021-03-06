#pragma checksum "/media/daniil/5CA854C8A854A276/VS_2019/ProektTRPO/Views/Home/Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6abd00164ae7834bce0821d49ade713a4dd6398d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/media/daniil/5CA854C8A854A276/VS_2019/ProektTRPO/Views/_ViewImports.cshtml"
using ProektTRPO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/media/daniil/5CA854C8A854A276/VS_2019/ProektTRPO/Views/_ViewImports.cshtml"
using ProektTRPO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6abd00164ae7834bce0821d49ade713a4dd6398d", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"015a9597a335e6e7d16c3920efc08cb2738fdb62", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/media/daniil/5CA854C8A854A276/VS_2019/ProektTRPO/Views/Home/Privacy.cshtml"
  
    ViewData["Title"] = "Теория";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Шифр Виженера</h1>

<p>Калькулятор шифрует входной текст на русском языке шифром Виженера. Неалфавитные символы (пробелы, знаки препинания, цифры) — не преобразуются..</p>
<p>
    Суть алгоритма шифрования проста. Шифр Виженера — это последовательность шифров Цезаря с различными значениями сдвига (ROTX — см. Шифр Цезаря). То есть к первой букве текста применяется преобразование, например, ROT5, ко второй, например, ROT17, и так далее. Последовательность применяемых преобразований определяется ключевой фразой, в которой каждая буква слова обозначает требуемый сдвиг, например, фраза ГДЕ ОН задает такую последовательность шифров Цезаря: ROT3-ROT4-ROT5-ROT15-ROT14, которая повторяется, пока не будет зашифрован весь текст сообщения.

    <br>
    Как повествует Википедия, шифр Виженера является шифром подстановки, то есть шифром, в котором каждая буква исходного текста заменяется буквой шифр-текста. Для вскрытия подобных шифров используется частотный криптоанализ.
    <br>
    Еще там можно прочитать ");
            WriteLiteral(@"про вариант шифра с бегущим ключом (running key), который был когда-то был невзламываемым. Этот вариант заключается в использовании в качестве ключа блока текста, равного по длине исходному тексту. Впрочем, и этот вариант, как оказалось, успешно поддается взлому. Проблема с бегущим ключом шифра Виженера состоит в том, что криптоаналитик имеет статистическую информацию о ключе (учитывая, что блок текста написан на известном языке) и эта информация будет отражаться в шифрованном тексте. Если ключ действительно случайный, его длина равна длине сообщения и он использовался единожды, то шифр Виженера теоретически будет невзламываемым, но такие системы уже относятся к классу систем одноразового кода, или одноразового шифр-блокнота (one-time pad). Они действительно не поддаются взлому, однако их практическое применение довольно затруднительно.
</p>
<h1>Шифр Цезаря</h1>

<p>Калькулятор шифрует входной текст на русском языке всеми возможными комбинациями шифра Цезаря. Неалфавитные символы (пробелы, знаки препинани");
            WriteLiteral(@"я, цифры) — не преобразуются.</p>

<p>
    Шифр Цезаря один из наиболее древнейших известных шифров. Схема шифрования очень проста — используется сдвиг буквы алфавита на фиксированное число позиций. Используемое преобразование обычно обозначают как ROTN, где N — сдвиг, ROT — сокращение от слова ROTATE, в данном случае «циклический сдвиг».

    <br />
    Алфавит действительно зацикливается, то есть буквы в конце алфавита преобразуются в буквы начала алфавита. Например, обозначение ROT2 обозначает сдвиг на 2 позиции, то есть, «а» превращается в «в», «б» в «г», и так далее, и в конце «ю» превращается в «а» а «я» — в «б». Число разных преобразований конечно и зависит от длины алфавита. Для русского языка возможно 32 разных преобразования (преобразования ROT0 и ROT33 сохраняют исходный текст, а дальше начинаются уже повторения). В связи с этим шифр является крайне слабым и исходный текст можно восстановить просто проверив все возможные преобразования.
    <br />

    Калькулятор выдает таблицу всех возмо");
            WriteLiteral("жных в шифре Цезаря преобразований введенного текста. Неалфавитные символы — знаки препинания, пробелы, цифры — не меняются.\r\n\r\n    Обновление: Добавлена возможность выбрать русский алфавит без буквы ё.\r\n</p>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
