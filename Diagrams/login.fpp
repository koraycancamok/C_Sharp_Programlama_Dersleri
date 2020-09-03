16       	 <--SHAPES
18       	 <--LINES
id1
2       	 <--TYPE
208       	 <--LEFT
56       	 <--TOP
70       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
START



id2
2       	 <--TYPE
491       	 <--LEFT
596       	 <--TOP
70       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
STOP



id3
91       	 <--TYPE
468       	 <--LEFT
58       	 <--TOP
188       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
INPUT
Kullanici adý
kadi

id4
91       	 <--TYPE
479       	 <--LEFT
119       	 <--TOP
148       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
INPUT
Parola
parola

id5
0       	 <--TYPE
442       	 <--LEFT
190       	 <--TOP
228       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
COMP
kadi
koraycan
durum
id6
92       	 <--TYPE
691       	 <--LEFT
274       	 <--TOP
112       	 <--WIDTH
50       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
IF_EQUAL
durum
0

id7
92       	 <--TYPE
668       	 <--LEFT
380       	 <--TOP
144       	 <--WIDTH
50       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
IF_EQUAL
parola
1234

id8
91       	 <--TYPE
645       	 <--LEFT
494       	 <--TOP
204       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
OUTPUT
sisteme giriþ yapildi


id9
91       	 <--TYPE
886       	 <--LEFT
278       	 <--TOP
196       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
OUTPUT
kullanici adi yanlis


id10
91       	 <--TYPE
916       	 <--LEFT
384       	 <--TOP
140       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
OUTPUT
parola yanlis


id12
3       	 <--TYPE
1381       	 <--LEFT
335       	 <--TOP
10       	 <--WIDTH
10       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
INTERSECTION



id13
0       	 <--TYPE
334       	 <--LEFT
66       	 <--TOP
84       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
DEFINITION
hak
3

id14
0       	 <--TYPE
815       	 <--LEFT
62       	 <--TOP
124       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
SUBTRACT
hak
1
hak
id11
92       	 <--TYPE
510       	 <--LEFT
272       	 <--TOP
112       	 <--WIDTH
50       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
IF_GREATER
hak
0

id15
91       	 <--TYPE
145       	 <--LEFT
278       	 <--TOP
196       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
OUTPUT
hesabiniz bloke oldu


id16
3       	 <--TYPE
284       	 <--LEFT
623       	 <--TOP
10       	 <--WIDTH
10       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
INTERSECTION



  
---- LINES ---- from,to ----
id3,id4
reserved 1

id4,id5
reserved 1

id6,id7
reserved 1
EVET
id7,id8
reserved 1
EVET
id8,id2
reserved 1

id6,id9
reserved 1
HAYIR
id7,id10
reserved 1
HAYIR
id10,id12
reserved 1

id1,id13
reserved 1

id13,id3
reserved 1

id9,id14
reserved 1

id14,id3
reserved 1

id12,id14
reserved 1

id5,id11
reserved 1

id11,id6
reserved 1
EVET
id11,id15
reserved 1
HAYIR
id15,id16
reserved 1

id16,id2
reserved 1

