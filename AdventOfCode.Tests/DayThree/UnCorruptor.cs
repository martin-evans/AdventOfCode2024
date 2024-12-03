using Xunit.Abstractions;

namespace AdventOfCode.Tests.DayThree;

public class UnCorrupterTests(ITestOutputHelper outputHelper)
{

    [Fact]
    public void ProofOfConcept()
    {
        var i = UnCorrupter.Calculate(TestInput.Example);
        
        outputHelper.WriteLine(i.ToString());
        
        Assert.Equal(161, i);

    }
    
    [Fact]
    public void Test1()
    {
        var i = UnCorrupter.Calculate(TestInput.Input);
        
        outputHelper.WriteLine(i.ToString());
        
        Assert.True(i> 0);

    }

    
}

public static class TestInput
{
    public const string Example = "xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))";

    public const string Input =
        "-~who()?!-{ where()mul(764,406)?^why()%[how(420,460)mul(69,497)where();'&>-!when()<^mul(629,650)mul(658,217))mul(553,521)][][*}>when()>]mul(927,175)]mul(364,814) &?what()/don't()#where(705,65)%@/}'#select()(mul(333,471)who()! @!,when()${mul(754,711)/don't()mul(148,921)*$&from()don't()where())mul(455,877)(from(519,591)/who()&when()select(401,718)['mul(870,745)who()@who()mul(92,899),# /<${what()mul(301,362)-mul(408,781)why()%(how()<}^/~mul(318,503);{(*,)when()mul(814,611),how()[<mul(228,415)#where()&/who()when()^[{+mul(344,298)when()mul(636,572)& ]$;%?mul(215,309)when():*do()/mul(792,335)>  why(){,,mul(525,151)#):^?,~who()do()mul(306,819)!'>$(!mul(294,958)^&how()who()[mul(194,339)((<mul(98,917)mul(133,311))what() ?mul(457,981)^)!(~!select()-mul(667,837)*!@from()*&,mul(274,151)(~when()<?>mul(84,363)why()who()mul(711,25)]why()(}mul(31,323);select()!select()mul(85,830)>&where(),({what()<,mul(404,568));$select()where()mul(238,707)what(797,319)'[?mul(603,3)where()>mul(827,90)[mul(288,639)![ what()how();why()mul(278,751)~select()@mul(970,757)select()?how()mul(36,900)-@mul(835,851)+,!mul(908,82)~&?mul(452,524)?[{)what()mul(491,590)who()-[from()]~{mul(333,397)mul(615,16)/mul(132,775)why()'!@* mul(203,604)'how(258,168)[when() ?$mul(731,849)>,+-#why()>when(19,498)]mul(329,904)*/#'']mul(644,691)&+~what():why()/from()}$do():'+,, mul(942,653)what() mul(676,56)/''):[>@<~mul(6,697)'mul(369,485)<!}<{@mul(593,437)':^mul(587,740)#+what()<}]@mul(544,337)mul(528,533)what()why(),@[@',-#don't()how()'what(401,682)mul(418,882)*mul(991,431)!]who()&!mul(30,319)do(),!$!when())@@mul(968,612)?how()?[mul(261,949)+@]:what(528,550)why()mul(745,147)[+when()%?why()[from()mul(759,21)%mul(319,271)@mul(580,221)who()why()()(*%mul(345,819)select();(what()@;,when()mul(433,622)mul(83,145)#;from()!#what()-mul(609,269)+why()mul(741,355)#mul(850,79)^~/mul(944,589)}%when()'{mul)mul(152,384)~?)how()mul(969,921)#-from()mul(283,868)mul(243,299)%}when()@mul(399,270)where(){'~[~do()mul(402,321)who()from()+why()how(),~&from()[mul(345,576}**mul(326,623)@where()>+;select()-'/mul(102,637))who()$,!^do();&+^}why(483,625)select()<what()mul(986,145)[#;<where()mul(973,528)[mul(153,242)}mul(413,240)(mul(631,220);]who()~*mul(980,831)[mul(907,168)mul(279,745)select()why(814,898)who(29,331){why(512,74)$&mul(606,720) ?mul(555,14)mul(577,376)what() mul(18,375)don't()$%,when()+?&@mul(463,674(? */},:-:@mul(124,324)}?who()^/ #!;mulwhere()from()>;-+]+@mul(558,499)+,]$$what()mul(73,35)where()how()+!mul(800,842)<:when()where()^who()<;/]mul(621,718)&select()^{:]mul(353,215):)#[mul(299,721),how()?,mul(911,921)&from()from()%+mul(19,957)when();!),++mul(441,742),$(^}(]]mul(622,972{]]where()<:how()$;who()mul(918,303)who()!mul(504,662)}how()when()(-+?do()~where())?-'select() [mul(533,672)@select(748,65)+where()'{'>don't():$#@:(select()mul(473,262)[how())<mul(573,666)&mul(969,473)(when()*!who()$^]#mul(214,766)]<?do()why()what()select()mul(470,943)+how()how()#/(where()mul(739,932)(: ;from()^/do()mul(898,691)~where()*when()select()*what()where()%#mul(319,166-&who() ~mul(72,647)!what(285,950)%?'mul(985,540)\nwhere(694,895)mul(736,442);what()<why():mul(476,579)]from()/-who()where()^/mul(7,937),who()select(319,835):^where()$^{how()mul(755,19)what()who()mul(80,314){<'(!#[mul(563,731)~mul(285,88)-what()>mul(569,348)&$+*;;mul(919,482)>#mul(275,890)who()%mul(689,521)what()+[-mul(116,646):select()@'^select()when()<>-mul(184select()from(),+)where()who(312,610);mul(473,864)>mul(943,380)}[,&[)?mul(352,764)where()#<where()/)}>mul(939,747)when()how(16,861)/select():why()mul(770,687)when()[how(),mul(289,328)mul(52,913)~+?who()mul(324,290):why()#from()mul(711,194)~<select()!?<#how()how()mul(675,226)mul(111,885)/?{what()!mul(580,679)who(769,426) ;[$]:!{#mul(464,404)'what()+mul/~mul(828,803)why()#{@why()why(){)mul(809,932)@(when();+{!don't()-&select()mul(624,523)what();:?select()] mul(952,680)select()[why(),/mul(966,356):who(282,988))(mul(552,661))mul(841,189){select()from()mulhow()select()$++mul(684,633)-*#select(687,346)][@<,+mul(912,573);)from()mul(745,363(,{mul(401,879)+???~)mul(523,857)@*{who()+,^^$,don't()/@mul(545,863))why()where()&when()how()when()*mul(680,541)what(){mul(238,859)^who()-mul(173,105)mul(356,774)&@;from():]who()mul(758,332)?:/mul(643,442)~how():,(&&mul!<@when()#mul(416,167)?;%)mul(907,888)select()*!#{[mul(452,595)!where()why()[mul(767,194)what()>~when() >[why();mul(635,124)&!from()@mul(71,301)where()&who()how()[mul(817,468)#{?,from()%}?where()(mul(991,655)?what()-why()don't():mul(324,148)mul(13,538)+[(~&/select()mul(887,419)what()<*!]:why()%$]do()@]#what()mul(864,345)<-(how()~^)where()what()&mul(991,25)how()^+-?mul(339,86)?select();@who()*)!}-mul(155,613)~$~{ }how()mul(812,654)~-#when()how()$[mul(386,847) ': -!'don't()from()from()[>mul(635,220)+<-!'&[{;when()mul(204,503)*@don't()~mul(913,575)when()!;^()%mul(313,960)from()from():/}mul(828,212):#;&($<<<-don't()?<(~who()'what()why()mul(454,310)($what();,&+~from()mul(51,471))who():mul(218,841)& mul(310,68from()mul(397,198),&] mul(107,89)<mul(620,335)select()/;,}@($'mul(713,177)what()~'%:where()mul(174,51):who()how(236,59)when(495,847)@mul(639,289)<where()&where(87,440)-when()$mul(71,771)-/{select()how()mul(624,295)(select()@mul(880,831)mul(41,537)^from())where()&where()$select(437,467)mul(959,111)/?^:/+mul(219,762)where()[what()^what()mul(57,744),mul(15,791)when()]]'where()~}~mul(354,865)what(627,774)where()mul(912,118){?}mul(53,256)@? {+mul(35,100)/what(){}] +@mul(340,487))mul(761,89)$+mul(862,420)?when()?why(895,459)why()]'>:mul(391,75)):?%where(),from()<mul(952,271)how()~[}-select()&(mul(90,422)^],mul(545,249) #}~?when()!when()mul(93,793)mul(401,403)$%select()&^/mul(821,313)%where()-mul(90,843)}what()*select()mul(399,618)<from())mul(531,529)#}%/~<{,}mul(227,911)why()[when()mul(778,507)%why();):(mul(206,671)when()mul(747,568)^mul(64,616)(}<:{-]when(14,389)^mul(648,520)select()when(53,345)%mul(771,307({(%when(),from()why()/*mul(72,835)why()mul(203,135)'~!when(),!;>[mul(24,801)]}[:who()^from(){![mul(875,162)from()mul(127,591)[don't())#who(),>@>who()[mul(732,249)when()^where()@!+';)-mul(407,186)>from(675,101)what()]%#mul(461,214)$:^/%}mul(650,791)select()(where()'[:;^^~mul(200,463)[?(>$->when(){mul(970,444),when(96,186)%:(who()]/)mul(236,599)[from()-select();',why()mul(259,290)mul(698,621)select()select()!what()[where()%*$where(467,148)mul(458,533when()- #@mul(810,353)\nwhat()/(>-when()%-do() :;how()'when()mul(928,260)*'/+what()where()mul(803,627)?#/$when()))mul(58%&!}^mul(784,330)who():'?]-[mul(480,39)/}#&do();*from()^mul(423,817)who():mul(758,858):)when()how(){-who()^ mul(986,262)<@~ *^what())mul(326,89)mul(863,330)'mul(797,517)+<who()%,:,< &mul(181,911)[who()[why()mul(786,389)&;where()mul(259,624),mul(725,17)* ^'<+?$~[mul(45,704)#  ^ mul(467,742)}mul(940,529){'#[[:mul(859,621)((where()who())from():}mul(563,851)[-what()mul(479,727)< when()!#mul(732,842);;where()mul(402,340)mul(237,505) %!mul(94,128)who()how();mul(575,722)]why();who()when()mul(688,182)where()#{~:how(336,945)+mul(256,256)why()$when()@mul(905,458)[when()<-?[why()(-;don't()*'mulwhy())why()mul(105,710){+^mul(316,625)}^*don't()how()what()!why()-;%who(383,603)mul(660,344)mul(588,300):mul(552,113) !*~ who()mul(815,752)-}@do(),>*&]from() }mul(681,55){*}why()who()mul(869,410)}#mul+/ mul(153,766)&^}@select()why()mul(30,619)how()<where()]& $:{$mul(249,820)-*!mul(782,869)from()how()-mul(955,896)mul(198,43)when()when()mul(570,606)!-}what()# mul(148,451)-how()+'mul(868,83)^^#when(61,767)&'mul(627,221)do()why()'/]mul(420,115))when()*;don't()what()mul(217,876)*+;%'/mul!}what()>who()?]mul(459,584)mul(119,326)<where()don't() <mul(95,805[?why(940,218)how()</mul(855,692)mul(246,352){<<when()&mul(254,154)when() 'where()how()mul(877,465&[who()who()select()how()!~[from()<mul(170,554)@ (?how()>&mul(627,843)'when()'!!@who()!!mul(211,446)(,{;>who(780,178)mul(483,646)$*how()select()%what()mul(113,924)@:mul(325,209)^[ @/%when()'{!mul(674,229)who()>]!?mul(306,16)]: mul(551,752)/@>where()'*mul(942,567)from()-from()mul(689,888)why()<*$select()how()[^[@mul(316,35)>*{+:when()mul(661,456)^$(,where()why()mul(972,157how()from()>+^!(>-mul(156,234)why()[mul^>&+what()?from()do()?#%why(){from(990,121)]how()/mul(201,545)from()<$where()>do()[when()when()'+when()~;&-mul(824,870))$-'where()when(547,415)]+/do()select()+what();#where()mul(442,767)'{%{!select()mul(131,742)mul(385,206)%&#~#@when(141,608)$/-do(){-:who()mul(241,754);}-&who(409,213)*{[mul(858,533{ $don't()from();who()]?select(459,962)who()where()when()mul(847,612why()[<]+*mul(89,985)~#&what(882,874)!!?why()mul(256,284),@}what() mul(845,617)what()from()mul(814,769)'!from()mul(685,850);>(who()who())what()%mul(142,506)what()/':?)(select()mul(159~;%}$^}what())mul(143,52)mul(2,339(>~'$(/~mul(208,220)$why()where()#][mul(622,831)~&@who()mul(841,258)select()/,@{-mul(943,197)what()mul(93,185)]]^^(select()from()*from() mul(233,470)-#@]who()#!what(721,647)mul(839,164)who()<?<-select()!where()from(774,762))don't()who()/&where()mul(27,58){when()^why(474,967):mul(505,7)mul(80,504)what()$,$#;~:^why()mul(586,784)^why():why(344,357)(why()mul(514,909) from()where()who()}how()!&mul(774,957)?where()-who();)]/&mul(716,576)mul(601,939)&[why()(>{mul(651,869)@^{&mul(28,23)> -'mul(593,606)]why() how()(mul(830,421)]mul(880!$who()/what()when()mul(299,889)mul(697,774)mul(7,535),where() }how(624,328)<%mul(670,193)}(when()[]mul(625,519)]@what()where()<who()(,mul(500,263)}),why()<when()#who()~how()mul(177,618)select()why()where()%+$!what()don't()[~select()mul(160,633)how(363,779)}&,)'mul(557,511)& ^mul(584,586)when()who()why()~$$mul(389,417)from(),select()when()?&@&mul(875,721)-why()when()why()mul(659,634)mul(396,299)#}@%/mul(496,203)~-mul(494,285);#(&]#(mul^?what()'how()!<when()mul(947,673)from(663,197)<what()don't()^/>[what()*mul(703,883)^>(from()select()where(468,413)]]?don't()what()why() +how()#!/usr/bin/perl*mul(358,599)}>~where()what()?: mul(802,575)<;when()do(),mul(198,240)\n!@%^mul(412,618)+# :mul(566,368)when()@%[!<mul(488,165)&?mul(743,549),%<what()do()how()?why()*mul(924,355)@[+~what()*@how()when()?mul(334,934)where(),'['@>+from()&mul:when()^:</~+&mul(244,156)$>*mul(139,569)where() @don't()#< (<mul(551,270)when()what()/select() when()?**]mul(79,597)'{@where()why()$what()mul(939when()!mul(104,966){;when(167,683)mul(865,591):}>:,!mul(787,971)how()select()where()?-from() mul(609,411)/$what()#what()%mul(452,921)/how(221,30)~what()mul(673,185)%what()mul(205,923)::)^]mul(625,543):~[why()?-$mul(476,415)[why()%when()why():mul(223,252)!~<how()/#why()from()<mul(524when() {;when()where(),why()mul(889,926)~why()*#-]how()mul(614,769)where()*what()!)how()'#mul(848,630)from(550,827)@where()#<()what(711,273)how(874,159)mul(700,475)select()*when()how()mul(455,994)mul(727,255)!{:@what(){/-mul(814,330)%from(293,654);<^:mul(45,143)#}&mul(571,876)%who()%[$]]^mul(491,788)from()>what():{from()}do()how()~;%mul(41,365)'*):who() ,$?&mul(905,180):#,%}mul(882( (&[+$mul(927,165)who()(don't()@(mul(246,147),why()#@%mul(381,509)what()who()]*]<mul(897,597)mul(860,194who()why()select()([who(788,843){>-mul(593,225) {*;]mul(771,843);-mul(764,968)#[,}select()-%#)mul(696,330) what()how(),:?;when();%mul(154,412)mul(426,382)/&'who()&~>);mul(990,3);>how(552,609)from()&)# mul> {[/;:/<do()<when(875,435)what(424,548),>+{mul(290,926)from()'mul(900,408)from()do()select()?%]&[-~mul(932,523)mul(477,866) ($#%mul(14,199)]mul(637,958)'where()what()$mul(777,762)$)what()mul(194,474),>what()$}[mul(521,703)$~- ]mul(897,954)+who()$mul(660,652)where()don't()where(779,173),how(753,110))]mul(488,877)+:(&from()where()~$%:mul(899,223)/why()mul(799,584)~]-(~mul(569:from())@]-(mul(247,152)?+)(from()mul(381,120)~mul(97,101)mul(448,487)when()from()mul(36,815)^}&:~!mul(35,211)*@#%/+)(,mul(288,994)why(546,78)^~)]?$from()who()mul(291,734)why()who() '@~ [mul(80,663)select()who()when()mul(288,196) &!where(212,346)<}mul(153,200)!([>mul(463,573when()%-mul(913,818);!!mul(842,31)'#%who()#-/mul(999,821),+/) -!what()why()mul(649,638)+{,/@why()]>from()mul(192,602))mul(623,469)-who()-*where()~)mul(753,337){[)mul(564,627))>how()('what()$]what()mul(422,110)*where()#]~mul(858,249) where(),+how()'*!mul(128,847){?^**@mul(424,825)mul(942,632);}when()mul(149,807)[?what(774,791)*[@mul(258,576)/~mul(13,896)where()}where(215,694)when():#/#select()#mul(528,826)#[<select()>/mul(190,170)~:)'who()'@?why()(mul(694,887)mul(873,610)where()'mul(704,477)%mul(964,286where()&what()do())mul(693,665)[<#(}?~mul(809,641)%>&<>@&mul(659,189)how()])}/-when()<&mul(278,575)?mul(383,999)(mul(321,263)who()mul(754,740) when():@*mul(720,146)?[how()*why()),~mul(836,890):#from() ~from(637,962)when()mul(922,625)&<who(919,427)&$>>where();mul(149,748)when()]%,?mul(429,943),&how()select()!}!&$mul(399,831)! <mul(905,545)(mul(757,572)!#!;do()from()why()mul(198,608)<>@::mul!@how()#'(mul(516,281){mul(540,282)^/what()[&(mul(235,845)mul(858<}why()-mul(541,246)when()mul(916@+select(118,658)mul(924,828) (why()'?:mul'from(){<~$how(784,54){what()~!do()~select() mul(659,852)mul(44,508)]*-~/when()from()what()!>mul(627,533)**don't()who(251,250)};select()from()?#>**mul(169,149),mul(31,376)&why();#when()select()/mul(689,237)'{}how()^how()~!select()mul(832,456)%,*,>mul(285,352)!%,from()@mul(446,359)where()mul(619,895)\n;{;]>)mul(41,286)who();mul(56,856)~]how()-mul(726,284)^mul(945,882)&+from(126,120))>){mul(797,922)mul(68,507)#-((mul(369,333)}what()>[:#^how()}+mul(185,65!!))mul(658,63))when()from()don't()' }-#mul(171,755)who()]mul(739,369)how()*when()mul(345,305)why()why()where()mul(418,411)when()mul(126,287)<!}<*^}mul(594,441)%~->@, why(55,552)};mul>~mul(291,290)why()mul(578?^*#(mul(182,165)&~ !mul*from()mul(101,921)!$:when()from()%mul(387,265)[@how()don't()^)%when()+:*/mul(44,589'<{from()&select()/mul(793,478);from()mul(271,291)&:>where()where()mul(229,293)][>{where()mul(928,6)+where()>)$^?mul(459,607))from(){how()>select()>:where(264,447)mul(684,815):[mul(347,990)>from()'<where()mul(395,156)(how() (/%{^when()mul(752,547)why()select()why())>~ ^mul(745,814)from(964,621)@<}@select()[@~mul(107,883)where()where(393,153)mul(963,967)) 'where():^&do()]from()why()what(),^mul(385,705)how()*>mul:?who(36,654)?mul(62,39): [mul(726,597)mul(763,90)[when());%mul(100,244)who()'(mul(55,288)%,<what()&when()do(),/,]mul(778,436)+'<,*!-mul(451,352)&when()(do(){mul(954,19)what()where()!]</]*^^mul(602,725)->)from()}'mul(346,82)mul(931,134)@when()@where()when(426,348){what()}mul)from()]mul(876,854)when()mul(223,775)who()-'why()) mul(898,755)(mul(777,419):;#~?:- 'mul(582,230)what()-&[mul(334,496)-$'+mul(674,926)^ @%don't()what(637,807)~from()mul(40,279))^mul(269,29)why()@(%why(537,715)~[-mul(670,805)select()>!<>mul(836,684)!{)mul(152,117)who()&mul(896,602)'why()])~{mul(766,101)where()when()how()>mul(766,84)when()what()@+;?mul(550,934)~mul(6,106)when()mul(637,11)&-mul(724,305)from()!--/#mul(62,495))why()!;#?mul(906,583)(':+ from())^mul(712,122)don't()!/mul(719,98)mul(504,23)->mul(912,622)&]when()@%why()(!mul(479%@when()>^# ~[#do()#who()what()who()( >^mul(110,206)!'don't()]*[how()@)mul(323,394)select()/mul(377,958)mul(143,494)]:what() ~;how()]mul(630,173)mul(973,759who()]select(104,775)when()how()mul(776,616)when(962,62)where()>~>/&*$mul(177,110)+)*mul(477,656)*%>where()where()](mul(190,616)from());,from()mul(936,105)[> mul(809,538)}mul(563,601)*how()(select() 'mul,&'-&{?[>what()mul(380,965)(what(778,700)mul(669,732)mul(966,367)(:#mul(321,737)how(912,962)?$'where()mul(860,148)&{/when(){*&*mul(742,21)%:&/mul(114,64)&mul(706,893)[*select()how()#^]{mul(339,536)?+how()}+mul(28,905)}#why()>why()%(mul(211,426)why()!~~-]mul(958,999)mul(635,537)'what()#mul(350,45)*?>mul(392,743)mul(639,758)who()mul(342,243) (how()select()-^what()[mul(107,290)[mul(76,140)%):~{/what()what(515,174)do()^#':/?mul[/+]@mul(207,882)what()mul(448,652'?;why()when();mul(509,549)',from(343,613)select()mul(657,688)]:*&>+mul(678]) ^<]mul(809,417)mul(172,314)$[how()mul(666,262))^select()-mul(215,760)#why()from()*mul(301,529)who(86,180))*[#,select()*don't()*@who()from()+where()$mul(944,345)who(),where(631,143)@}<]<select(449,764)-mul(174,53)do()mul(305,421)from()'^where()# >mul(82,32)!where()]where(324,391)who()~<mul(818,551[,?<why()@'[,mul(465,988)$;who()what()?how()mul(486,789)why(),;who()?&}mul(419,207)%~<>?where(), mul(13,167)when()why()[]>%<'mul(24,374)?mul(932,568)who()([@?}how();$]don't()^*%:@>from()how()mul(100,246)who(147,869)-mul(743,461)>/%who()mul(733,280)-how()where()$[mul(397,950)\n>,)>mul(921,777)where()/:-%what()- [do() what(655,775)from()when();}mul(513,785)?>~+~mul(656,887)?+select()<^mul(589,966)&why()mul(287,686)(who())$!<{((mul(4,157)from()}!?,what()'where()mul(617,343)<:why()]why()'&do()%@%what(5,890)what()mul(271,55)what()(where()}'-?)mul(582,649)%)/mul(176select()when()what(),mul(659,68)>>$@select()select()mul(373,308);^when()?]from()~}who()do()?[#mul(572,701)&mul(30,709)[[;why()mul(353,243)-how())>what()~~select()mul(63,496)mul(137,334)< mul(991,76)##how(),'~~?}#mul(485,797)mul(636,71)select(149,192)${{mul(774,387){where(){}~where()mul(418,125)+who()+from()where()$)$/what(368,73)mul(256,560)>when()]mul(631,272)mul(713,265))*{^where()[%select()mul(792,576)?mul(146,670)mul(73,111)<{)*[/]who(130,798)>:mul(820,581)^: (mul(899,649)(#?]mul(230,883)~/what(),%$;^>mul(145,724)*@]!>where())when()don't()what()*@{select()mul(424,670)*$mul(514,265who(),<@/#why()why();{mul(804,700),)why()#} *]]/mul(28,284)where() !:{*+when()mul(930,21)from()+who()what():?who()>mul(119,587)#mul(366,632)mul(710,996)why()select(676,739)}:@mul(427,253)[>#>mul(486,35)where()><when(),$from()do()$,(&~*where(143,63)mul(522,764)+mul(755,793)when()why()$]?mul(685,620)@who()select()-]#mul(763,532)!^mul(157,853)}@&,:mul(376,536)+from()mul(280,439)from()>#[%when();'* mul(368,692) '}!%+&(/?mul(233,760)+what(),:#':what()+what()mul(489,225)+{mul(977,940)%/^mul(124,752):when(577,707)%when()[mul(483,254)#:?^when()*^mul(23,268)mul(48,566)}'#mul(879,408)&from()what())[}$$why()mul(633,365)(mul(135,837)@'()&@&~mul(347,314)^<;mul(301,516) ^$((?what()(&what()do()[mul(883,466)##,*$mul(273,756)}[how() what()*~where()>mul(89,229)from()??why()~mul(622,308)%!$how()>do()](<~what() ^^!mul(941,422)[]how()don't(),>:where()>when() why(417,45)%why()mul(815,766)!]( <mul(115,810)@{[mul(969,807)@select()%from(){}?mul(206,32)/)?,@;/*mul(143,854)where()*how(191,454)&},]>$mul(409,145)<select()%[[&~mul(728,456)do()mul(904,568)<#select()where()[(-,^*mul(349,775) who()&'^'?when()mul(286,875)*^{+when()what(481,754)  $mul(279,388)from()>!'?)mul(81,823)*mul(443,168)?when()?mul(475,220)/),+where():do())}when()**+{mul(651,45);#how()]%mul(837,911) >^}}!how()mul(699,375)^why(905,878)how()(}mul(936,779)[don't()mul(928,258)how()~/->mul(65,102)@*from()^]&(+mul(517,48)how() #'< >mul(846,43){from():what()why()(where()})mul(77,705)when()mul(885,675)mul(180,761)^>^(:&do()from()[#<-when()%~mul(743,829):when();$mul(99,676)who()!:&<mul(223,288)[when()mul(358,710)how() #)select()what()'}mul(336,503)what()'>+;}mul(412,553) -]}^mul(824,352)from()+mul(282,920)who()how(){%where()~^mul(252,21)what()/{-mul(958,613)(-:mul(696,876)/why()#mul(761,290)#,mul(971,166)mul(761,359)mul(349,153):}select()where()mul(640,511)@;%where()-'mul(472,839)why()#'from()where()#--mul(823,302)! select()?;+},(>mul(255,432)mul(30,380)*/how()mul(852,651)who()$ where()<#how(),mul(683,385)mul(988,590)how()who()'>-mul(608,251)what()@*?who()!/mul(992,768)#'";
}