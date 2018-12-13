�9
_C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Characters\Character.vb
Partial 
Public 
Class 
	Character 
Inherits 
AnimatedSprite 
Friend 

Velocity 
As 
New 
Vector2 "
(" #
$num# $
,$ %
$num& '
)' (
Friend 

Acceleration 
As 
New 
Vector2 &
(& '
$num' (
,( )
$num* +
)+ ,
Public 


IsGrounded 
As 
Boolean  
=! "
True# '
Public 

Alive 
As 
Boolean 
= 
True "
Public 

ViewDirection 
As 
ViewDirections *
=+ ,
ViewDirections- ;
.; <
Right< A
Public 

Visible 
As 
Boolean 
= 
True  $
Public 


HasGravity 
As 
Boolean  
=! "
True# '
Public   

CharacterType   
As   
CharacterTypes   *
Public$$ 

HealthPoints$$ 
As$$ 
Integer$$ "
=$$# $
$num$$% (
Public(( 

Weapon(( 
As(( 
Weapon(( 
Public** 

Enum** 
CharacterTypes** 
Player++ 
Enemy,, 
Friendly-- 
End.. 
Enum.. 
Public00 

Enum00 
ViewDirections00 
Left11 
Right22 
End33 
Enum33 
Sub55 
New55 
(55 
	_frmWidth55 
As55 
Integer55  
,55  !
_cType55" (
As55) +
CharacterTypes55, :
)55: ;
MyBase66 
.66 
New66 
(66 
	_frmWidth66 
)66 
CharacterType88 
=88 
_cType88 
Weapon99 
=99 
New99 
Pistol99 
(99 
CharacterType99 )
)99) *
End:: 
Sub:: 
Public<< 

Sub<< 
Jump<< 
(<< 
)<< 
If== 


IsGrounded== 
Then== 
Velocity>> 
.>> 
Y>> 
=>> 
->> 
$num>> 
End?? 
If?? 
End@@ 
Sub@@ 
PublicBB 

	OverridesBB 
SubBB 
UpdateBB 
(BB  
gameTimeBB  (
AsBB) +
GameTimeBB, 4
)BB4 5
MyBaseCC 
.CC 
UpdateCC 
(CC 
gameTimeCC 
)CC 
DimEE 
_newPosEE 
AsEE 
Vector2EE 
=EE  
VelocityEE! )
*EE* +
CSngEE, 0
(EE0 1
gameTimeEE1 9
.EE9 :
ElapsedGameTimeEE: I
.EEI J
TotalSecondsEEJ V
)EEV W
IfGG 


HasGravityGG 
ThenGG 
CollidingCheckHH 
(HH 
_newPosHH "
,HH" #
gameTimeHH$ ,
)HH, -
EndII 
IfII 
WeaponKK 
.KK 
PositionKK 
=KK 
PositionKK "
WeaponLL 
.LL 
UpdateLL 
(LL 
gameTimeLL 
)LL 
IfNN 

HealthPointsNN 
<NN 
$numNN 
ThenNN  
AliveOO 
=OO 
FalseOO 
EndPP 
IfPP 
EndRR 
SubRR 
PublicTT 

	OverridesTT 
SubTT 
DrawTT 
(TT 
sbTT  
AsTT! #
SpriteBatchTT$ /
)TT/ 0
IfUU 

VisibleUU 
ThenUU 
IfVV 
SelectedAnimationVV  
IsNotVV! &
NothingVV' .
ThenVV/ 3
sbWW 
.WW 
DrawWW 
(WW 
SelectedAnimationWW )
.WW) *
TextureWW* 1
,WW1 2
NewWW3 6
	RectangleWW7 @
(WW@ A
CIntWWA E
(WWE F
PositionWWF N
.WWN O
XWWO P
)WWP Q
,WWQ R
CIntWWS W
(WWW X
PositionWWX `
.WW` a
YWWa b
)WWb c
,WWc d

FrameWidthWWe o
,WWo p
SelectedAnimation	WWq �
.
WW� �
Texture
WW� �
.
WW� �
Height
WW� �
)
WW� �
,
WW� �
srcRect
WW� �
,
WW� �
Color
WW� �
.
WW� �
White
WW� �
)
WW� �
EndXX 
IfXX 
WeaponZZ 
.ZZ 
DrawZZ 
(ZZ 
sbZZ 
,ZZ 
MeZZ 
)ZZ 
End[[ 
If[[ 
End\\ 
Sub\\ 
Public^^ 

	Overrides^^ 
Function^^ 
GetTrueRect^^ )
(^^) *
)^^* +
As^^, .
	Rectangle^^/ 8
Return__ 
New__ 
	Rectangle__ 
(__ 
Position__ %
.__% &
ToPoint__& -
,__- .
getTextureSize__/ =
.__= >
ToPoint__> E
)__E F
End`` 
Function`` 
Publicbb 

	Overridesbb 
Functionbb 
GetScreenRectbb +
(bb+ ,
)bb, -
Asbb. 0
	Rectanglebb1 :
Dimcc 
selectedLevelcc 
=cc 
ScreenHandlercc )
.cc) *
SelectedScreencc* 8
.cc8 9
ToWorldcc9 @
.cc@ A
SelectedLevelccA N
Returndd 
Newdd 
	Rectangledd 
(dd 
Positiondd %
.dd% &
ToPointdd& -
-dd. /
Newdd0 3
Pointdd4 9
(dd9 :
CIntdd: >
(dd> ?
selectedLeveldd? L
.ddL M
CameraddM S
.ddS T
TranslationddT _
.dd_ `
Xdd` a
)dda b
,ddb c
CIntddd h
(ddh i
selectedLevelddi v
.ddv w
Cameraddw }
.dd} ~
Translation	dd~ �
.
dd� �
Y
dd� �
)
dd� �
)
dd� �
,
dd� �
getTextureSize
dd� �
.
dd� �
ToPoint
dd� �
)
dd� �
Endee 
Functionee 
Publicgg 

Overridablegg 
Subgg 
Interactiongg &
(gg& '
)gg' (
Endii 
Subii 
Publickk 

Subkk 
SwitchViewDirectionkk "
(kk" #
)kk# $
Selectll 
Casell 
ViewDirectionll !
Casemm 
ViewDirectionsmm 
.mm  
Leftmm  $
ViewDirectionnn 
=nn 
ViewDirectionsnn  .
.nn. /
Rightnn/ 4
Caseoo 
ViewDirectionsoo 
.oo  
Rightoo  %
ViewDirectionpp 
=pp 
ViewDirectionspp  .
.pp. /
Leftpp/ 3
Endqq 
Selectqq 
Endrr 
Subrr 
Endss 
Classss 	�\
_C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Characters\Collision.vb
Partial 
Public 
Class 
	Character 
Private 
Sub 
CollidingCheck 
( 
displacement +
As, .
Vector2/ 6
,6 7
gameTime8 @
AsA C
GameTimeD L
)L M
Dim 
_rect 
As 
New 
	Rectangle "
(" #
CInt# '
(' (
GetTrueRect( 3
.3 4
X4 5
+6 7
displacement8 D
.D E
XE F
)F G
-H I
$numJ K
,K L
CIntM Q
(Q R
GetTrueRectR ]
.] ^
Y^ _
+` a
displacementb n
.n o
Yo p
)p q
-r s
$numt u
,u v
GetTrueRect	w �
.
� �
Width
� �
+
� �
$num
� �
,
� �
GetTrueRect
� �
.
� �
Height
� �
+
� �
$num
� �
)
� �
Acceleration 
. 
Y 
+= 
CSng 
( 
$num "
*# $
gameTime% -
.- .
ElapsedGameTime. =
.= >
TotalSeconds> J
+K L
$numM Q
)Q R
Velocity

 
+=

 
Acceleration

  
*

! "
CSng

# '
(

' (
gameTime

( 0
.

0 1
ElapsedGameTime

1 @
.

@ A
TotalSeconds

A M
)

M N
If 

Velocity 
. 
Y 
< 
$num 
AndAlso !
Not" %
Keyboard& .
.. /
GetState/ 7
.7 8
	IsKeyDown8 A
(A B
KeysB F
.F G
SpaceG L
)L M
ThenN R
Velocity 
+= 
Acceleration $
*% &
CSng' +
(+ ,
gameTime, 4
.4 5
ElapsedGameTime5 D
.D E
TotalSecondsE Q
)Q R
End 
If 
If 

ScreenHandler 
. 
SelectedScreen '
.' (
GetType( /
(/ 0
)0 1
=2 3
GetType4 ;
(; <
World< A
)A B
ThenC G
Dim 
colBot 
As 
Boolean !
=" #"
CheckCollidingVertical$ :
(: ;
displacement; G
)G H
If 
colBot 
Then 
Else 
Position 
. 
Y 
+= 
CSng "
(" #
Velocity# +
.+ ,
Y, -
*. /
gameTime0 8
.8 9
ElapsedGameTime9 H
.H I
TotalSecondsI U
)U V
End 
If 
If 
CheckCollidingSides "
(" #
displacement# /
)/ 0
Then1 5
Else 
Position 
. 
X 
+= 
CSng "
(" #
Velocity# +
.+ ,
X, -
*. /
gameTime0 8
.8 9
ElapsedGameTime9 H
.H I
TotalSecondsI U
)U V
End 
If 
End   
If   
End!! 
Sub!! 
Private(( 
Function(( "
CheckCollidingVertical(( +
(((+ ,
displacement((, 8
As((9 ;
Vector2((< C
)((C D
As((E G
Boolean((H O
Try)) 
If** 
displacement** 
.** 
Y** 
<** 
$num**  !
Then**" &

IsGrounded,, 
=,, 
False,, "
Dim-- 

playerRect-- 
=--  
New--! $
	Rectangle--% .
(--. /
GetTrueRect--/ :
.--: ;
X--; <
,--< =
CInt--> B
(--B C
GetTrueRect--C N
.--N O
Y--O P
+--Q R
displacement--S _
.--_ `
Y--` a
---b c
$num--d e
)--e f
,--f g
GetTrueRect--h s
.--s t
Width--t y
,--y z
GetTrueRect	--{ �
.
--� �
Height
--� �
)
--� �
Dim// 
wObjColliding// !
=//" #)
GetWorldObjectRectIsColliding//$ A
(//A B

playerRect//B L
)//L M
If00 
wObjColliding00  
IsNot00! &
Nothing00' .
Then00/ 3
Position11 
.11 
Y11 
=11  
wObjColliding11! .
.11. /
GetTrueRect11/ :
.11: ;
Y11; <
+11= >
wObjColliding11? L
.11L M
GetTrueRect11M X
.11X Y
Height11Y _
Acceleration22  
.22  !
Y22! "
=22# $
$num22% &
Velocity33 
.33 
Y33 
=33  
$num33! "
Return44 
True44 
Else55 
Return66 
False66  
End77 
If77 
ElseIf:: 
displacement:: 
.::  
Y::  !
>::" #
$num::$ %
Then::& *
Dim<< 

playerRect<< 
=<<  
New<<! $
	Rectangle<<% .
(<<. /
GetTrueRect<</ :
.<<: ;
X<<; <
,<<< =
CInt<<> B
(<<B C
GetTrueRect<<C N
.<<N O
Y<<O P
+<<Q R
displacement<<S _
.<<_ `
Y<<` a
+<<b c
$num<<d e
)<<e f
,<<f g
GetTrueRect<<h s
.<<s t
Width<<t y
,<<y z
GetTrueRect	<<{ �
.
<<� �
Height
<<� �
)
<<� �
Dim>> 
wObjColliding>> !
=>>" #)
GetWorldObjectRectIsColliding>>$ A
(>>A B

playerRect>>B L
)>>L M
If?? 
wObjColliding??  
IsNot??! &
Nothing??' .
Then??/ 3
Position@@ 
.@@ 
Y@@ 
=@@  
wObjColliding@@! .
.@@. /
GetTrueRect@@/ :
.@@: ;
Y@@; <
-@@= >
GetTrueRect@@? J
.@@J K
Height@@K Q
AccelerationAA  
.AA  !
YAA! "
=AA# $
$numAA% &
VelocityBB 
.BB 
YBB 
=BB  
$numBB! "

IsGroundedCC 
=CC  
TrueCC! %
ReturnDD 
TrueDD 
ElseEE 

IsGroundedFF 
=FF  
FalseFF! &
ReturnGG 
FalseGG  
EndHH 
IfHH 
ElseLL 
ReturnMM 
FalseMM 
EndNN 
IfNN 
CatchOO 
exOO 
AsOO $
IndexOutOfRangeExceptionOO ,
ReturnPP 
FalsePP 
EndQQ 
TryQQ 
EndRR 
FunctionRR 
PrivateTT 
FunctionTT 
CheckCollidingSidesTT (
(TT( )
displacementTT) 5
AsTT6 8
Vector2TT9 @
)TT@ A
AsTTB D
BooleanTTE L
TryUU 
IfVV 
displacementVV 
.VV 
XVV 
<VV 
$numVV  !
ThenVV" &
DimWW 

playerRectWW 
=WW  
NewWW! $
	RectangleWW% .
(WW. /
CIntWW/ 3
(WW3 4
GetTrueRectWW4 ?
.WW? @
XWW@ A
+WWB C
displacementWWD P
.WWP Q
XWWQ R
-WWS T
$numWWU V
)WWV W
,WWW X
GetTrueRectWWY d
.WWd e
YWWe f
,WWf g
GetTrueRectWWh s
.WWs t
WidthWWt y
,WWy z
GetTrueRect	WW{ �
.
WW� �
Height
WW� �
)
WW� �
DimYY 
wObjCollidingYY !
=YY" #)
GetWorldObjectRectIsCollidingYY$ A
(YYA B

playerRectYYB L
)YYL M
IfZZ 
wObjCollidingZZ  
IsNotZZ! &
NothingZZ' .
ThenZZ/ 3
Position[[ 
.[[ 
X[[ 
=[[  
wObjColliding[[! .
.[[. /
GetTrueRect[[/ :
.[[: ;
X[[; <
+[[= >
wObjColliding[[? L
.[[L M
GetTrueRect[[M X
.[[X Y
Width[[Y ^
Acceleration\\  
.\\  !
X\\! "
=\\# $
$num\\% &
Velocity]] 
.]] 
X]] 
=]]  
$num]]! "
Return^^ 
True^^ 
Else__ 
Return`` 
False``  
Endaa 
Ifaa 
ElseIfdd 
displacementdd 
.dd  
Xdd  !
>dd" #
$numdd$ %
Thendd& *
Dimee 

playerRectee 
=ee  
Newee! $
	Rectangleee% .
(ee. /
CIntee/ 3
(ee3 4
GetTrueRectee4 ?
.ee? @
Xee@ A
+eeB C
displacementeeD P
.eeP Q
XeeQ R
+eeS T
$numeeU V
)eeV W
,eeW X
GetTrueRecteeY d
.eed e
Yeee f
,eef g
GetTrueRecteeh s
.ees t
Widtheet y
,eey z
GetTrueRect	ee{ �
.
ee� �
Height
ee� �
)
ee� �
Dimgg 
wObjCollidinggg !
=gg" #)
GetWorldObjectRectIsCollidinggg$ A
(ggA B

playerRectggB L
)ggL M
Ifhh 
wObjCollidinghh  
IsNothh! &
Nothinghh' .
Thenhh/ 3
Positionii 
.ii 
Xii 
=ii  
wObjCollidingii! .
.ii. /
GetTrueRectii/ :
.ii: ;
Xii; <
-ii= >
GetTrueRectii? J
.iiJ K
WidthiiK P
Accelerationjj  
.jj  !
Xjj! "
=jj# $
$numjj% &
Velocitykk 
.kk 
Xkk 
=kk  
$numkk! "
Returnll 
Truell 
Elsemm 
Returnnn 
Falsenn  
Endoo 
Ifoo 
Elseqq 
Returnrr 
Falserr 
Endss 
Ifss 
Catchtt 
extt 
Astt $
IndexOutOfRangeExceptiontt ,
Returnuu 
Falseuu 
Endvv 
Tryvv 
Endww 
Functionww 
Privateyy 
Functionyy )
GetWorldObjectRectIsCollidingyy 2
(yy2 3
rectyy3 7
Asyy8 :
	Rectangleyy; D
)yyD E
AsyyF H
WorldObjectyyI T
Forzz 
Eachzz 
wObjzz 
Inzz 
ScreenHandlerzz &
.zz& '
SelectedScreenzz' 5
.zz5 6
ToWorldzz6 =
.zz= >
SelectedLevelzz> K
.zzK L
PlacedObjectszzL Y
If{{ 
rect{{ 
.{{ 

Intersects{{ 
({{ 
wObj{{ #
.{{# $
GetTrueRect{{$ /
){{/ 0
AndAlso{{1 8
wObj{{9 =
.{{= >
zIndex{{> D
={{E F
$num{{G H
Then{{I M
Return|| 
wObj|| 
End}} 
If}} 
Next~~ 
Return 
Nothing 
End
�� 
Function
�� 
End�� 
Class
�� 	�,
[C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Characters\Enemy.vb
Public 
Class 
Enemy 
Inherits 
NPC 
Dim 
Player 
As 
Player 
= 
ScreenHandler (
.( )
SelectedScreen) 7
.7 8
ToWorld8 ?
.? @
Player@ F
Sub		 
New		 
(		 
	_frmWidth		 
As		 
Integer		  
)		  !
MyBase

 
.

 
New

 
(

 
	_frmWidth

 
,

 
CharacterTypes

 ,
.

, -
Enemy

- 2
)

2 3
End 
Sub 
Dim  
viewDirectionCounter 
As 
Integer  '
=( )
$num* +
Public 

	Overrides 
Sub 
Update 
(  
gameTime  (
As) +
GameTime, 4
)4 5
MyBase 
. 
Update 
( 
gameTime 
) 
If 

IsPlayerInSight 
( 
) 
Then !
Select 
Case 
ViewDirection %
Case 
ViewDirections #
.# $
Left$ (
Weapon 
. 
	ShootLeft $
($ %
)% &
Case 
ViewDirections #
.# $
Right$ )
Weapon 
. 

ShootRight %
(% &
)& '
End 
Select  
viewDirectionCounter  
=! "
$num# $
Else 
If  
viewDirectionCounter #
>$ %
$num& *
Then+ /
SwitchViewDirection #
(# $
)$ % 
viewDirectionCounter $
=% &
$num' (
End 
If 
End 
If  
viewDirectionCounter"" 
+="" 
CInt""  $
(""$ %
gameTime""% -
.""- .
ElapsedGameTime"". =
.""= >
TotalMilliseconds""> O
)""O P
End## 
Sub## 
Dim%% 
viewRect%% 
As%% 
	Rectangle%% 
Public&& 

Function&& 
IsPlayerInSight&& #
(&&# $
)&&$ %
As&&& (
Boolean&&) 0
If'' 

Math'' 
.'' 
Abs'' 
('' 
Player'' 
.'' 
Position'' #
.''# $
X''$ %
-''& '
Position''( 0
.''0 1
X''1 2
)''2 3
>''4 5
$num''6 9
Then'': >
Return(( 
False(( 
End)) 
If)) 
Select++ 
Case++ 
ViewDirection++ !
Case,, 
ViewDirections,, 
.,,  
Left,,  $
viewRect-- 
=-- 
New-- 
	Rectangle-- (
(--( )
CInt--) -
(--- .
Player--. 4
.--4 5
Position--5 =
.--= >
X--> ?
)--? @
,--@ A
CInt--B F
(--F G
Position--G O
.--O P
Y--P Q
)--Q R
,--R S
CInt--T X
(--X Y
Position--Y a
.--a b
X--b c
---d e
Player--f l
.--l m
Position--m u
.--u v
X--v w
)--w x
,--x y
$num--z |
)--| }
Case// 
ViewDirections// 
.//  
Right//  %
viewRect00 
=00 
New00 
	Rectangle00 (
(00( )
CInt00) -
(00- .
Position00. 6
.006 7
X007 8
)008 9
,009 :
CInt00; ?
(00? @
Position00@ H
.00H I
Y00I J
)00J K
,00K L
CInt00M Q
(00Q R
Player00R X
.00X Y
Position00Y a
.00a b
X00b c
-00d e
Position00f n
.00n o
X00o p
)00p q
,00q r
$num00s u
)00u v
End11 
Select11 
For33 
Each33 
wObj33 
In33 
ScreenHandler33 &
.33& '
SelectedScreen33' 5
.335 6
ToWorld336 =
.33= >
SelectedLevel33> K
.33K L
PlacedObjects33L Y
If44 
viewRect44 
.44 

Intersects44 "
(44" #
wObj44# '
.44' (
GetTrueRect44( 3
)443 4
AndAlso445 <
wObj44= A
.44A B
GetType44B I
=44J K
GetType44L S
(44S T
WorldObject44T _
)44_ `
Then44a e
Return55 
False55 
End66 
If66 
Next77 
If99 

Player99 
.99 
GetTrueRect99 
.99 

Intersects99 (
(99( )
viewRect99) 1
)991 2
Then993 7
Return:: 
True:: 
End;; 
If;; 
Return== 
False== 
End>> 
Function>> 
Public@@ 

	Overrides@@ 
Sub@@ 
Draw@@ 
(@@ 
sb@@  
As@@! #
SpriteBatch@@$ /
)@@/ 0
MyBaseAA 
.AA 
DrawAA 
(AA 
sbAA 
)AA 
EndBB 
SubBB 
EndCC 
ClassCC 	�
^C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Characters\Friendly.vb
Public 
Class 
Friendly 
Inherits 
NPC 
Sub 
New 
( 
	_frmWidth 
As 
Integer  
)  !
MyBase 
. 
New 
( 
	_frmWidth 
, 
CharacterTypes ,
., -
Friendly- 5
)5 6
End 
Sub 
End 
Class 	�
YC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Characters\NPC.vb
Public 
Class 
NPC 
Inherits 
	Character 
Public 

Dialogue 
As 
Dialogue 
=  !
Nothing" )
Sub		 
New		 
(		 
	_frmWidth		 
As		 
Integer		  
,		  !
_cType		" (
As		) +
CharacterTypes		, :
)		: ;
MyBase

 
.

 
New

 
(

 
	_frmWidth

 
,

 
_cType

 $
)

$ %
End 
Sub 
Public 

	Overrides 
Sub 
Update 
(  
gameTime  (
As) +
GameTime, 4
)4 5
MyBase 
. 
Update 
( 
gameTime 
) 
If 

Dialogue 
IsNot 
Nothing !
Then" &
Dialogue 
. 
Update 
( 
gameTime $
)$ %
End 
If 
If 

Acceleration 
. 
X 
= 
$num 
Then "
Velocity 
. 
X 
/= 
$num 
If 
Velocity 
. 
X 
< 
$num 
Then  $
Velocity 
. 
X 
= 
$num 
End 
If 
End 
If 
End 
Sub 
Public 

	Overrides 
Sub 
Draw 
( 
sb  
As! #
SpriteBatch$ /
)/ 0
MyBase 
. 
Draw 
( 
sb 
) 
End 
Sub 
Public   

Sub   
DrawDialogue   
(   
sb   
As   !
SpriteBatch  " -
)  - .
If!! 

Dialogue!! 
IsNot!! 
Nothing!! !
Then!!" &
Dialogue"" 
."" 
Draw"" 
("" 
sb"" 
)"" 
End## 
If## 
End$$ 
Sub$$ 
Public&& 

	Overrides&& 
Sub&& 
Interaction&& $
(&&$ %
)&&% &
MyBase'' 
.'' 
Interaction'' 
('' 
)'' 
If)) 

Dialogue)) 
IsNot)) 
Nothing)) !
Then))" &
ScreenHandler** 
.** 
SelectedScreen** (
.**( )
ToWorld**) 0
.**0 1
Player**1 7
.**7 8
IsInDialogue**8 D
=**E F
True**G K
Dialogue++ 
.++ 
Active++ 
=++ 
True++ "
End,, 
If,, 
End-- 
Sub-- 
End.. 
Class.. 	�G
\C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Characters\Player.vb
Public 
Class 
Player 
Inherits 
	Character 
Public 

IsInDialogue 
As 
Boolean "
=# $
False% *
Sub		 
New		 
(		 
)		 
MyBase

 
.

 
New

 
(

 
$num

 
,

 
CharacterTypes

 %
.

% &
Player

& ,
)

, -

Animations 
= 
AnimationSets "
." #
Player# ) 
SetSelectedAnimation 
( 
$str #
)# $
End 
Sub 
Public 

	Overrides 
Sub 
Update 
(  
gameTime  (
As) +
GameTime, 4
)4 5
Dim 
maxSpeed 
= 
$num 
If 

Not 
IsInDialogue 
Then  
If 
Keyboard 
. 
GetState  
.  !
	IsKeyDown! *
(* +
Keys+ /
./ 0
A0 1
)1 2
Then3 7
If 
Velocity 
. 
X 
> 
$num  !
Then" &
Velocity 
. 
X 
+= !
-" #
$num# %
ElseIf 
Velocity 
.  
X  !
>" #
-$ %
maxSpeed% -
Then. 2
Velocity 
. 
X 
+= !
-" #
$num# $
End 
If 
ElseIf 
Keyboard 
. 
GetState $
.$ %
	IsKeyDown% .
(. /
Keys/ 3
.3 4
D4 5
)5 6
Then7 ;
If 
Velocity 
. 
X 
< 
$num  !
Then" &
Velocity 
. 
X 
+= !
$num" $
ElseIf 
Velocity 
.  
X  !
<" #
maxSpeed$ ,
Then- 1
Velocity   
.   
X   
+=   !
$num  " #
End!! 
If!! 
Else"" 
If## 

IsGrounded## 
Then## "
If$$ 
Velocity$$ 
.$$  
X$$  !
>$$" #
$num$$$ %
Then$$& *
Velocity%%  
.%%  !
X%%! "
+=%%# %
-%%& '
$num%%' )
ElseIf&& 
Velocity&& #
.&&# $
X&&$ %
<&&& '
$num&&( )
Then&&* .
Velocity''  
.''  !
X''! "
+=''# %
$num''& (
End(( 
If(( 
Else** 
If,, 
Velocity,, 
.,,  
X,,  !
>,," #
$num,,$ %
Then,,& *
Velocity--  
.--  !
X--! "
+=--# %
---& '
$num--' (
ElseIf.. 
Velocity.. #
...# $
X..$ %
<..& '
$num..( )
Then..* .
Velocity//  
.//  !
X//! "
+=//# %
$num//& '
End00 
If00 
End11 
If11 
If33 
Velocity33 
.33 
X33 
<33 
$num33  "
AndAlso33# *
Velocity33+ 3
.333 4
X334 5
>336 7
-338 9
$num339 ;
Then33< @
Velocity44 
.44 
X44 
=44  
$num44! "
End55 
If55 
End66 
If66 
If88 
Keyboard88 
.88 
GetState88  
.88  !
	IsKeyDown88! *
(88* +
Keys88+ /
.88/ 0
Space880 5
)885 6
Then887 ;
Jump99 
(99 
)99 
End:: 
If:: 
If<< 
Keyboard<< 
.<< 
GetState<<  
.<<  !
	IsKeyDown<<! *
(<<* +
Keys<<+ /
.<</ 0
E<<0 1
)<<1 2
Then<<3 7
Interact== 
(== 
)== 
End>> 
If>> 
If@@ 
Mouse@@ 
.@@ 
GetState@@ 
.@@ 

LeftButton@@ (
=@@) *
ButtonState@@+ 6
.@@6 7
Pressed@@7 >
AndAlso@@? F
Not@@G J
Weapon@@K Q
.@@Q R
CurrentlyReloading@@R d
Then@@e i
ShootAtMouseAA 
(AA 
)AA 
EndBB 
IfBB 
IfDD 
KeyboardDD 
.DD 
GetStateDD  
.DD  !
	IsKeyDownDD! *
(DD* +
KeysDD+ /
.DD/ 0
RDD0 1
)DD1 2
AndAlsoDD3 :
NotDD; >
WeaponDD? E
.DDE F
CurrentlyReloadingDDF X
AndAlsoDDY `
WeaponDDa g
.DDg h
ProjectilesInMagDDh x
<DDy z
Weapon	DD{ �
.
DD� �
ProjectilesMagMax
DD� �
Then
DD� �
WeaponEE 
.EE 
ReloadWeaponEE #
(EE# $
gameTimeEE$ ,
)EE, -
EndFF 
IfFF '
ActivateWorldObjectsInRangeHH '
(HH' (
)HH( )
MyBaseJJ 
.JJ 
UpdateJJ 
(JJ 
gameTimeJJ "
)JJ" #
EndKK 
IfKK 
EndLL 
SubLL 
PublicNN 

SubNN '
ActivateWorldObjectsInRangeNN *
(NN* +
)NN+ ,
ForOO 
EachOO 
wObjOO 
InOO 
ScreenHandlerOO &
.OO& '
SelectedScreenOO' 5
.OO5 6
ToWorldOO6 =
.OO= >
SelectedLevelOO> K
.OOK L
PlacedObjectsOOL Y
IfPP 
wObjPP 
IsNotPP 
NothingPP !
ThenPP" &
IfQQ 
Vector2QQ 
.QQ 
DistanceQQ #
(QQ# $
wObjQQ$ (
.QQ( )
GetTrueRectQQ) 4
.QQ4 5
LocationQQ5 =
.QQ= >
	ToVector2QQ> G
,QQG H
MeQQI K
.QQK L
PositionQQL T
)QQT U
<QQV W
$numQQX Z
ThenQQ[ _
wObjRR 
.RR 
IsPlayerInRangeRR (
=RR) *
TrueRR+ /
ElseSS 
wObjTT 
.TT 
IsPlayerInRangeTT (
=TT) *
FalseTT+ 0
EndUU 
IfUU 
EndVV 
IfVV 
NextWW 
EndXX 
SubXX 
PublicZZ 

SubZZ 
InteractZZ 
(ZZ 
)ZZ 
Dim[[ 
SelectedLevel[[ 
=[[ 
ScreenHandler[[ )
.[[) *
SelectedScreen[[* 8
.[[8 9
ToWorld[[9 @
.[[@ A
SelectedLevel[[A N
For]] 
Each]] 
NPC]] 
In]] 
SelectedLevel]] %
.]]% &
NPCs]]& *
If^^ 
NPC^^ 
.^^ 
GetTrueRect^^ 
.^^ 

Intersects^^ )
(^^) *
Me^^* ,
.^^, -
GetTrueRect^^- 8
)^^8 9
Then^^: >
NPC__ 
.__ 
Interaction__ 
(__  
)__  !
Return`` 
Endaa 
Ifaa 
Nextbb 
Fordd 
Eachdd 
wObjdd 
Indd 
SelectedLeveldd &
.dd& '
PlacedObjectsdd' 4
Ifee 
wObjee 
IsNotee 
Nothingee !
AndAlsoee" )
wObjee* .
.ee. /
GetTrueRectee/ :
.ee: ;

Intersectsee; E
(eeE F
NeweeF I
	RectangleeeJ S
(eeS T
GetTrueRecteeT _
.ee_ `
Leftee` d
-eee f
$numeeg i
,eei j
GetTrueRecteek v
.eev w
Topeew z
,eez {
GetTrueRect	ee| �
.
ee� �
Width
ee� �
+
ee� �
$num
ee� �
,
ee� �
GetTrueRect
ee� �
.
ee� �
Height
ee� �
)
ee� �
)
ee� �
Then
ee� �
wObjff 
.ff 
Interactionff  
(ff  !
)ff! "
Returngg 
Endhh 
Ifhh 
Nextii 
Endjj 
Subjj 
Privatell 
Subll 
ShootAtMousell 
(ll 
)ll 
Weaponmm 
.mm 
ShootAtmm 
(mm 
Miscmm 
.mm 
ScreenPosToWorldPosmm /
(mm/ 0
Mousemm0 5
.mm5 6
GetStatemm6 >
.mm> ?
Positionmm? G
)mmG H
)mmH I
Endnn 
Subnn 
Endoo 
Classoo 	�
`C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Characters\Weapons\AR.vb
Public 
Class 
AR 
Inherits 
Weapon 
Sub 
New 
( 
_cType 
As 
	Character 
.  
CharacterTypes  .
). /
MyBase 
. 
New 
( 
_cType 
) 
Cooldown 
= 
$num 
ProjectileDamage 
= 
$num 
ProjectileSpeed		 
=		 
$num		 
End 
Sub 
Private 
Sub 
AR_ShotFired 
( 
) 
Handles &
MyBase' -
.- .
	ShotFired. 7
Sounds 
. 
Weapons 
. 
Pistol 
. 
Shoot #
.# $
CreateInstance$ 2
.2 3
Play3 7
(7 8
)8 9
End 
Sub 
Private 
Sub 
AR_ReloadStarted  
(  !
)! "
Handles# *
MyBase+ 1
.1 2
ReloadStarted2 ?
Sounds 
. 
Weapons 
. 
Pistol 
. 
Reload $
.$ %
CreateInstance% 3
.3 4
Play4 8
(8 9
)9 :
End 
Sub 
End 
Class 	�
mC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Characters\Weapons\GrenadeLauncher.vb
Public 
Class 
GrenadeLauncher 
Inherits 
Weapon 
Sub 
New 
( 
_cType 
As 
	Character 
.  
CharacterTypes  .
). /
MyBase 
. 
New 
( 
_cType 
) 
ProjectileSpeed		 
=		 
$num		 
End

 
Sub

 
Friend 

	Overrides 
Sub 
SpawProjectile '
(' (
	_position( 1
As2 4
Vector25 <
,< =
	_velocity> G
AsH J
Vector2K R
,R S
_damageT [
As\ ^
Integer_ f
)f g
Projectiles 
. 
Add 
( 
New 

Projectile &
(& '
	_position' 0
,0 1
	_velocity2 ;
,; <
_damage= D
,D E
CharacterTypeF S
)S T
WithU Y
{Z [
.[ \
Acceleration\ h
=i j
Newk n
Vector2o v
(v w
-w x
$numx z
,z {
$num| ~
)~ 
}	 �
)
� �
End 
Sub 
Public 

	Overrides 
Sub 
OnProjectileImpact +
(+ ,
ByRef, 1
sender2 8
As9 ;

Projectile< F
)F G
ScreenHandler 
. 
SelectedScreen $
.$ %
ToWorld% ,
., -
SelectedLevel- :
.: ;
Explode; B
(B C
senderC I
.I J
PositionJ R
,R S
$numT V
)V W
End 
Sub 
End 
Class 	�
dC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Characters\Weapons\Pistol.vb
Public 
Class 
Pistol 
Inherits 
Weapon 
Sub 
New 
( 
_cType 
As 
	Character 
.  
CharacterTypes  .
). /
MyBase 
. 
New 
( 
_cType 
) 
Cooldown 
= 
$num 
ProjectileDamage 
= 
$num 
End		 
Sub		 
Private 
Sub 
Pistol_ShotFired  
(  !
)! "
Handles# *
MyBase+ 1
.1 2
	ShotFired2 ;
SoundSystem 
. 
Play 
( 
Sounds 
.  
Weapons  '
.' (
Pistol( .
.. /
Shoot/ 4
)4 5
End 
Sub 
Private 
Sub  
Pistol_ReloadStarted $
($ %
)% &
Handles' .
MyBase/ 5
.5 6
ReloadStarted6 C
SoundSystem 
. 
Play 
( 
Sounds 
.  
Weapons  '
.' (
Pistol( .
.. /
Reload/ 5
)5 6
End 
Sub 
End 
Class 	��
tC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Characters\Weapons\Projectiles\Projectile.vb
Public 
Class 

Projectile 
Inherits 
Sprite 
Public 

Velocity 
As 
Vector2 
Public 

Acceleration 
As 
New 
Vector2 &
(& '
$num' (
,( )
$num* +
)+ ,
Public		 

Damage		 
As		 
Integer		 
Public

 

Existing

 
As

 
Boolean

 
=

  
True

! %
Public 

Landed 
As 
Boolean 
= 
False $
Public 


WithEvents 
ps 
As 
ParticleSystem *
Public 

Origin 
As 
	Character 
. 
CharacterTypes -
Dim 
Rotation 
As 
Single 
Public 

Event 
ProjectileImpact !
(! "
ByRef" '
sender( .
As/ 1

Projectile2 <
)< =
Public 

Enum 
Side 
None 
Top 
Bottom 
Left 
Right 
All 
End 
Enum 
Sub 
New 
( 
_pos 
As 
Vector2 
, 
_vel !
As" $
Vector2% ,
,, -
_dmg. 2
As3 5
Integer6 =
,= >
_origin? F
AsG I
	CharacterJ S
.S T
CharacterTypesT b
)b c
Position 
= 
_pos 
Velocity 
= 
_vel 
Damage   
=   
_dmg   
Rotation!! 
=!! 
CSng!! 
(!! 
Math!! 
.!! 
Atan2!! "
(!!" #
Velocity!!# +
.!!+ ,
Y!!, -
,!!- .
Velocity!!/ 7
.!!7 8
X!!8 9
)!!9 :
)!!: ;
Origin"" 
="" 
_origin"" 
End## 
Sub## 
Dim%% 
counter%% 
As%% 
Integer%% 
=%% 
$num%% 
Public&& 

	Overrides&& 
Sub&& 
Update&& 
(&&  
gameTime&&  (
As&&) +
GameTime&&, 4
)&&4 5
If'' 

Not'' 
Landed'' 
Then'' 
Velocity(( 
.(( 
Y(( 
+=(( 
Acceleration(( &
.((& '
Y((' (
*(() *
CSng((+ /
(((/ 0
gameTime((0 8
.((8 9
ElapsedGameTime((9 H
.((H I
TotalSeconds((I U
)((U V
Velocity)) 
.)) 
X)) 
=)) 
()) 
Math)) 
.)) 
Abs)) "
())" #
Velocity))# +
.))+ ,
X)), -
)))- .
+))/ 0
Acceleration))1 =
.))= >
X))> ?
*))@ A
CSng))B F
())F G
gameTime))G O
.))O P
ElapsedGameTime))P _
.))_ `
TotalSeconds))` l
)))l m
)))m n
*))o p
Math))q u
.))u v
Sign))v z
())z {
Velocity	)){ �
.
))� �
X
))� �
)
))� �
Position++ 
+=++ 
Velocity++  
*++! "
CSng++# '
(++' (
gameTime++( 0
.++0 1
ElapsedGameTime++1 @
.++@ A
TotalSeconds++A M
)++M N
Select?? 
Case?? 
CheckCollision?? &
(??& '
)??' (
Case@@ 
Side@@ 
.@@ 
Left@@ 
LandedAA 
=AA 
TrueAA !

RaiseEventCC 
ProjectileImpactCC /
(CC/ 0
MeCC0 2
)CC2 3
psEE 
=EE 
NewEE 
ParticleSystemEE +
(EE+ ,
PositionEE, 4
)EE4 5
WithEE6 :
{EE; <
.EE< =
ParticleFadeTimeEE= M
=EEN O
$numEEP S
,EES T
.EEU V
ParticleLifetimeEEV f
=EEg h
$numEEi m
,EEm n
.EEo p
PossibleTextures	EEp �
=
EE� �
{
EE� �
Textures
EE� �
.
EE� �
ParticleSpark
EE� �
}
EE� �
,
EE� �
.FF< ="
ParticleVelocityLowestFF= S
=FFT U
NewFFV Y
PointFFZ _
(FF_ `
-FF` a
$numFFa c
,FFc d
-FFe f
$numFFf h
)FFh i
,FFi j
.FFk l$
ParticleVelocityHighest	FFl �
=
FF� �
New
FF� �
Point
FF� �
(
FF� �
$num
FF� �
,
FF� �
$num
FF� �
)
FF� �
}
FF� �
psHH 
.HH 
SpawnParticlesHH %
(HH% &
$numHH& '
)HH' (
CaseJJ 
SideJJ 
.JJ 
RightJJ 
LandedKK 
=KK 
TrueKK !

RaiseEventMM 
ProjectileImpactMM /
(MM/ 0
MeMM0 2
)MM2 3
psOO 
=OO 
NewOO 
ParticleSystemOO +
(OO+ ,
PositionOO, 4
)OO4 5
WithOO6 :
{OO; <
.OO< =
ParticleFadeTimeOO= M
=OON O
$numOOP S
,OOS T
.OOU V
ParticleLifetimeOOV f
=OOg h
$numOOi m
,OOm n
.OOo p
PossibleTextures	OOp �
=
OO� �
{
OO� �
Textures
OO� �
.
OO� �
ParticleSpark
OO� �
}
OO� �
,
OO� �
.PP< ="
ParticleVelocityLowestPP= S
=PPT U
NewPPV Y
PointPPZ _
(PP_ `
$numPP` a
,PPa b
-PPc d
$numPPd f
)PPf g
,PPg h
.PPi j$
ParticleVelocityHighest	PPj �
=
PP� �
New
PP� �
Point
PP� �
(
PP� �
$num
PP� �
,
PP� �
$num
PP� �
)
PP� �
}
PP� �
psRR 
.RR 
SpawnParticlesRR %
(RR% &
$numRR& '
)RR' (
CaseTT 
SideTT 
.TT 
TopTT 
LandedUU 
=UU 
TrueUU !

RaiseEventWW 
ProjectileImpactWW /
(WW/ 0
MeWW0 2
)WW2 3
psYY 
=YY 
NewYY 
ParticleSystemYY +
(YY+ ,
PositionYY, 4
)YY4 5
WithYY6 :
{YY; <
.YY< =
ParticleFadeTimeYY= M
=YYN O
$numYYP S
,YYS T
.YYU V
ParticleLifetimeYYV f
=YYg h
$numYYi m
,YYm n
.YYo p
PossibleTextures	YYp �
=
YY� �
{
YY� �
Textures
YY� �
.
YY� �
ParticleSpark
YY� �
}
YY� �
,
YY� �
.ZZ< ="
ParticleVelocityLowestZZ= S
=ZZT U
NewZZV Y
PointZZZ _
(ZZ_ `
-ZZ` a
$numZZa c
,ZZc d
-ZZe f
$numZZf h
)ZZh i
,ZZi j
.ZZk l$
ParticleVelocityHighest	ZZl �
=
ZZ� �
New
ZZ� �
Point
ZZ� �
(
ZZ� �
$num
ZZ� �
,
ZZ� �
$num
ZZ� �
)
ZZ� �
}
ZZ� �
ps\\ 
.\\ 
SpawnParticles\\ %
(\\% &
$num\\& '
)\\' (
Case^^ 
Side^^ 
.^^ 
Bottom^^  
Landed__ 
=__ 
True__ !

RaiseEventaa 
ProjectileImpactaa /
(aa/ 0
Meaa0 2
)aa2 3
pscc 
=cc 
Newcc 
ParticleSystemcc +
(cc+ ,
Positioncc, 4
)cc4 5
Withcc6 :
{cc; <
.cc< =
ParticleFadeTimecc= M
=ccN O
$numccP S
,ccS T
.ccU V
ParticleLifetimeccV f
=ccg h
$numcci m
,ccm n
.cco p
PossibleTextures	ccp �
=
cc� �
{
cc� �
Textures
cc� �
.
cc� �
ParticleSpark
cc� �
}
cc� �
,
cc� �
.dd< ="
ParticleVelocityLowestdd= S
=ddT U
NewddV Y
PointddZ _
(dd_ `
-dd` a
$numdda c
,ddc d
$numdde f
)ddf g
,ddg h
.ddi j$
ParticleVelocityHighest	ddj �
=
dd� �
New
dd� �
Point
dd� �
(
dd� �
$num
dd� �
,
dd� �
$num
dd� �
)
dd� �
}
dd� �
psff 
.ff 
SpawnParticlesff %
(ff% &
$numff& '
)ff' (
Casehh 
Sidehh 
.hh 
Allhh 
Landedii 
=ii 
Trueii !

RaiseEventkk 
ProjectileImpactkk /
(kk/ 0
Mekk0 2
)kk2 3
psmm 
=mm 
Newmm 
ParticleSystemmm +
(mm+ ,
Positionmm, 4
)mm4 5
Withmm6 :
{mm; <
.mm< =
ParticleFadeTimemm= M
=mmN O
$nummmP S
,mmS T
.mmU V
ParticleLifetimemmV f
=mmg h
$nummmi m
,mmm n
.mmo p
PossibleTextures	mmp �
=
mm� �
{
mm� �
Textures
mm� �
.
mm� �
ParticleSpark
mm� �
}
mm� �
,
mm� �
.nn< ="
ParticleVelocityLowestnn= S
=nnT U
NewnnV Y
PointnnZ _
(nn_ `
-nn` a
$numnna c
,nnc d
-nne f
$numnnf h
)nnh i
,nni j
.nnk l$
ParticleVelocityHighest	nnl �
=
nn� �
New
nn� �
Point
nn� �
(
nn� �
$num
nn� �
,
nn� �
$num
nn� �
)
nn� �
}
nn� �
pspp 
.pp 
SpawnParticlespp %
(pp% &
$numpp& '
)pp' (
Endqq 
Selectqq 
Elserr 
psss 
.ss 
Updatess 
(ss 
gameTimess 
)ss 
countertt 
+=tt 
CInttt 
(tt 
gameTimett $
.tt$ %
ElapsedGameTimett% 4
.tt4 5
TotalMillisecondstt5 F
)ttF G
Ifuu 
counteruu 
=uu 
$numuu 
Thenuu !
Existingvv 
=vv 
Falsevv  
Endww 
Ifww 
Endxx 
Ifxx 
Endyy 
Subyy 
Public{{ 

	Overrides{{ 
Sub{{ 
Draw{{ 
({{ 
sb{{  
As{{! #
SpriteBatch{{$ /
){{/ 0
If|| 

Not|| 
Landed|| 
Then|| 
sb}} 
.}} 
Draw}} 
(}} 
Textures}} 
.}} 
Bullet}} #
,}}# $
Position}}% -
,}}- .
Nothing}}/ 6
,}}6 7
Color}}8 =
.}}= >
White}}> C
,}}C D
Rotation}}E M
,}}M N
New}}O R
Vector2}}S Z
(}}Z [
CSng}}[ _
(}}_ `
Textures}}` h
.}}h i
Bullet}}i o
.}}o p
Width}}p u
/}}v w
$num}}x y
)}}y z
,}}z {
CSng	}}| �
(
}}� �
Textures
}}� �
.
}}� �
Bullet
}}� �
.
}}� �
Height
}}� �
/
}}� �
$num
}}� �
)
}}� �
)
}}� �
,
}}� �
$num
}}� �
,
}}� �
Nothing
}}� �
,
}}� �
Nothing
}}� �
)
}}� �
End~~ 
If~~ 
If
�� 

ps
�� 
IsNot
�� 
Nothing
�� 
Then
��  
ps
�� 
.
�� 
Draw
�� 
(
�� 
sb
�� 
)
�� 
End
�� 
If
�� 
End
�� 
Sub
�� 
Private
�� 
LastPosition
�� 
As
�� 
Vector2
�� #
Private
�� 
Function
�� 
CheckCollision
�� #
(
��# $
)
��$ %
As
��& (
Side
��) -
Dim
�� 
selectedLevel
�� 
=
�� 
ScreenHandler
�� )
.
��) *
SelectedScreen
��* 8
.
��8 9
ToWorld
��9 @
.
��@ A
SelectedLevel
��A N
If
�� 

(
�� 
CInt
�� 
(
�� 
Math
�� 
.
�� 
Floor
�� 
(
�� 
Position
�� $
.
��$ %
X
��% &
/
��' (
$num
��) +
)
��+ ,
)
��, -
>
��. /
$num
��0 1
AndAlso
��2 9
CInt
��: >
(
��> ?
Math
��? C
.
��C D
Floor
��D I
(
��I J
Position
��J R
.
��R S
X
��S T
/
��U V
$num
��W Y
)
��Y Z
)
��Z [
<
��\ ]
selectedLevel
��^ k
.
��k l
GetLevelSize
��l x
(
��x y
)
��y z
.
��z {
X
��{ |
)
��| }
AndAlso��~ �
(
�� 
CInt
�� 
(
�� 
Math
�� 
.
�� 
Floor
�� 
(
�� 
Position
�� %
.
��% &
Y
��& '
/
��( )
$num
��* ,
)
��, -
)
��- .
>
��/ 0
$num
��1 2
AndAlso
��3 :
CInt
��; ?
(
��? @
Math
��@ D
.
��D E
Floor
��E J
(
��J K
Position
��K S
.
��S T
Y
��T U
/
��V W
$num
��X Z
)
��Z [
)
��[ \
<
��] ^
selectedLevel
��_ l
.
��l m
GetLevelSize
��m y
(
��y z
)
��z {
.
��{ |
Y
��| }
)
��} ~
Then�� �
For
�� 
Each
�� 
wObj
�� 
In
�� 
selectedLevel
�� *
.
��* +
PlacedObjects
��+ 8
If
�� 
GetTrueRect
�� 
.
�� 

Intersects
�� )
(
��) *
wObj
��* .
.
��. /
GetTrueRect
��/ :
)
��: ;
AndAlso
��< C
wObj
��D H
.
��H I
zIndex
��I O
=
��P Q
$num
��R S
Then
��T X
If
�� 
LastPosition
�� #
.
��# $
Y
��$ %
<
��& '
wObj
��( ,
.
��, -
rect
��- 1
.
��1 2
Y
��2 3
*
��4 5
$num
��6 8
Then
��9 =
Return
�� 
Side
�� #
.
��# $
Top
��$ '
ElseIf
�� 
LastPosition
�� '
.
��' (
Y
��( )
>
��* +
wObj
��, 0
.
��0 1
rect
��1 5
.
��5 6
Y
��6 7
*
��8 9
$num
��: <
+
��= >
wObj
��? C
.
��C D
rect
��D H
.
��H I
Height
��I O
Then
��P T
Return
�� 
Side
�� #
.
��# $
Bottom
��$ *
ElseIf
�� 
LastPosition
�� '
.
��' (
X
��( )
<
��* +
wObj
��, 0
.
��0 1
rect
��1 5
.
��5 6
X
��6 7
*
��8 9
$num
��: <
Then
��= A
Return
�� 
Side
�� #
.
��# $
Left
��$ (
ElseIf
�� 
LastPosition
�� '
.
��' (
X
��( )
>
��* +
wObj
��, 0
.
��0 1
rect
��1 5
.
��5 6
X
��6 7
*
��8 9
$num
��: <
+
��= >
wObj
��? C
.
��C D
rect
��D H
.
��H I
Width
��I N
Then
��O S
Return
�� 
Side
�� #
.
��# $
Right
��$ )
Else
�� 
Return
�� 
Side
�� #
.
��# $
All
��$ '
End
�� 
If
�� 
End
�� 
If
�� 
Next
�� 
Else
�� 
Return
�� 
Side
�� 
.
�� 
All
�� 
End
�� 
If
�� 
Dim
�� 
rect
�� 
As
�� 
New
�� 
	Rectangle
�� !
(
��! "
CInt
��" &
(
��& '
Position
��' /
.
��/ 0
X
��0 1
)
��1 2
,
��2 3
CInt
��4 8
(
��8 9
Position
��9 A
.
��A B
Y
��B C
)
��C D
,
��D E
Textures
��F N
.
��N O
Bullet
��O U
.
��U V
Width
��V [
,
��[ \
Textures
��] e
.
��e f
Bullet
��f l
.
��l m
Height
��m s
)
��s t
Select
�� 
Case
�� 
Origin
�� 
Case
�� 
	Character
�� 
.
�� 
CharacterTypes
�� )
.
��) *
Player
��* 0
For
�� 
Each
�� 
	character
�� "
As
��# %
	Character
��& /
In
��0 2
selectedLevel
��3 @
.
��@ A
NPCs
��A E
If
�� 
rect
�� 
.
�� 

Intersects
�� &
(
��& '
	character
��' 0
.
��0 1
GetTrueRect
��1 <
)
��< =
Then
��> B
	character
�� !
.
��! "
HealthPoints
��" .
-=
��/ 1
Me
��2 4
.
��4 5
Damage
��5 ;
	character
�� !
.
��! "
Velocity
��" *
+=
��+ -
New
��. 1
Vector2
��2 9
(
��9 :
Math
��: >
.
��> ?
Sign
��? C
(
��C D
Me
��D F
.
��F G
Velocity
��G O
.
��O P
X
��P Q
)
��Q R
*
��S T
$num
��U X
,
��X Y
$num
��Z [
)
��[ \
Return
�� 
Side
�� #
.
��# $
All
��$ '
End
�� 
If
�� 
Next
�� 
Case
�� 
	Character
�� 
.
�� 
CharacterTypes
�� )
.
��) *
Enemy
��* /
Dim
�� 
Player
�� 
As
�� 
Player
�� $
=
��% &
ScreenHandler
��' 4
.
��4 5
SelectedScreen
��5 C
.
��C D
ToWorld
��D K
.
��K L
Player
��L R
If
�� 
rect
�� 
.
�� 

Intersects
�� "
(
��" #
Player
��# )
.
��) *
GetTrueRect
��* 5
)
��5 6
Then
��7 ;
Player
�� 
.
�� 
HealthPoints
�� '
-=
��( *
Me
��+ -
.
��- .
Damage
��. 4
Return
�� 
Side
�� 
.
��  
All
��  #
End
�� 
If
�� 
End
�� 
Select
�� 
LastPosition
�� 
=
�� 
Position
�� 
Return
�� 
Side
�� 
.
�� 
None
�� 
End
�� 
Function
�� 
Private
�� 
Sub
�� 
DeleteProjectile
��  
(
��  !
)
��! "
Handles
��# *
ps
��+ -
.
��- . 
ParticlesDespawned
��. @
If
�� 

Landed
�� 
Then
�� 
Existing
�� 
=
�� 
False
�� 
End
�� 
If
�� 
End
�� 
Sub
�� 
End�� 
Class
�� 	�N
dC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Characters\Weapons\Weapon.vb
Public 
Class 
Weapon 
Public		 

Projectiles		 
As		 
New		 
List		 "
(		" #
Of		# %

Projectile		& 0
)		0 1
Public 

Cooldown 
As 
Integer 
=  
$num! $
Public 

ProjectileDamage 
As 
Integer &
=' (
$num) *
Public 

ProjectileSpeed 
As 
Integer %
=& '
$num( +
Public 

Position 
As 
Vector2 
Public 

ProjectilesInMag 
As 
Integer &
Public!! 

ProjectilesMagMax!! 
As!! 
Integer!!  '
=!!( )
$num!!* ,
Public%% 


ReloadTime%% 
As%% 
Integer%%  
=%%! "
$num%%# '
Public)) 

CharacterType)) 
As)) 
	Character)) %
.))% &
CharacterTypes))& 4
Public-- 

CurrentlyReloading-- 
As--  
Boolean--! (
=--) *
False--+ 0
Public11 

Event11 
ReloadStarted11 
(11 
)11  
Public55 

Event55 
	ShotFired55 
(55 
)55 
Sub77 
New77 
(77 
_cType77 
As77 
	Character77 
.77  
CharacterTypes77  .
)77. /
ProjectilesInMag88 
=88 
ProjectilesMagMax88 ,
CharacterType:: 
=:: 
_cType:: 
End;; 
Sub;; 
Public== 

Overridable== 
Sub== 
Update== !
(==! "
gameTime==" *
As==+ -
GameTime==. 6
)==6 7
For>> 
Each>> 
_bul>> 
In>> 
Projectiles>> $
_bul?? 
.?? 
Update?? 
(?? 
gameTime??  
)??  !
Next@@ 
IfBB 

CurrentlyReloadingBB 
ThenBB "
ReloadWeaponCC 
(CC 
gameTimeCC !
)CC! "
EndDD 
IfDD 
ProjectilesFF 
.FF 
	RemoveAllFF 
(FF 
FunctionFF &
(FF& '
xFF' (
)FF( )
xFF* +
.FF+ ,
ExistingFF, 4
=FF5 6
FalseFF7 <
)FF< =!
BulletCooldownCounterHH 
+=HH  
CIntHH! %
(HH% &
gameTimeHH& .
.HH. /
ElapsedGameTimeHH/ >
.HH> ?
TotalMillisecondsHH? P
)HHP Q
EndII 
SubII 
DimKK !
BulletCooldownCounterKK 
AsKK  
IntegerKK! (
=KK) *
$numKK+ ,
PublicPP 

SubPP 
ShootAtPP 
(PP 
_targetPP 
AsPP !
Vector2PP" )
)PP) *
IfQQ 
!
BulletCooldownCounterQQ  
>QQ! "
CooldownQQ# +
ThenQQ, 0
IfRR 
ProjectilesInMagRR 
>RR  !
$numRR" #
ThenRR$ (

RaiseEventSS 
	ShotFiredSS $
(SS$ %
)SS% &
SpawProjectileUU 
(UU 
PositionUU '
,UU' (
Vector2UU) 0
.UU0 1
	NormalizeUU1 :
(UU: ;
_targetUU; B
-UUC D
PositionUUE M
)UUM N
*UUO P
ProjectileSpeedUUQ `
,UU` a
$numUUb d
)UUd e
ProjectilesInMagVV  
-=VV! #
$numVV$ %

AddHandlerXX 
ProjectilesXX &
(XX& '
ProjectilesXX' 2
.XX2 3
CountXX3 8
-XX9 :
$numXX; <
)XX< =
.XX= >
ProjectileImpactXX> N
,XXN O
	AddressOfXXP Y
OnProjectileImpactXXZ l!
BulletCooldownCounterZZ %
=ZZ& '
$numZZ( )
Else[[ 
CurrentlyReloading\\ "
=\\# $
True\\% )
End]] 
If]] 
End^^ 
If^^ 
End__ 
Sub__ 
Publicdd 

Subdd 
	ShootLeftdd 
(dd 
)dd 
ShootAtee 
(ee 
Positionee 
+ee 
Newee 
Vector2ee &
(ee& '
-ee' (
$numee( )
,ee) *
$numee+ ,
)ee, -
)ee- .
Endff 
Subff 
Publickk 

Subkk 

ShootRightkk 
(kk 
)kk 
ShootAtll 
(ll 
Positionll 
+ll 
Newll 
Vector2ll &
(ll& '
$numll' (
,ll( )
$numll* +
)ll+ ,
)ll, -
Endmm 
Submm 
Frienduu 

Overridableuu 
Subuu 
SpawProjectileuu )
(uu) *
positionuu* 2
Asuu3 5
Vector2uu6 =
,uu= >
velocityuu? G
AsuuH J
Vector2uuK R
,uuR S
damageuuT Z
Asuu[ ]
Integeruu^ e
)uue f
Projectilesvv 
.vv 
Addvv 
(vv 
Newvv 

Projectilevv &
(vv& '
positionvv' /
,vv/ 0
velocityvv1 9
,vv9 :
damagevv; A
,vvA B
CharacterTypevvC P
)vvP Q
)vvQ R
Endww 
Subww 
Publicyy 

Overridableyy 
Subyy 
Drawyy 
(yy  
_sbyy  #
Asyy$ &
SpriteBatchyy' 2
,yy2 3
Optionalyy4 <
_parentyy= D
AsyyE G
	CharacteryyH Q
=yyR S
NothingyyT [
)yy[ \
Ifzz 

_parentzz 
IsNotzz 
Nothingzz  
AndAlsozz! (
TypeOfzz) /
(zz0 1
_parentzz1 8
)zz8 9
Iszz: <
Playerzz= C
ThenzzD H
If{{ 
CurrentlyReloading{{ !
Then{{" &
Misc}} 
.}} 
DrawRectangle}} "
(}}" #
_sb}}# &
,}}& '
New}}( +
	Rectangle}}, 5
(}}5 6
_parent}}6 =
.}}= >
Position}}> F
.}}F G
ToPoint}}G N
+}}O P
New}}Q T
Point}}U Z
(}}Z [
$num}}[ \
,}}\ ]
-}}^ _
$num}}_ a
)}}a b
,}}b c
New}}d g
Point}}h m
(}}m n
CInt}}n r
(}}r s
_parent}}s z
.}}z {
getTextureSize	}}{ �
.
}}� �
X
}}� �
)
}}� �
,
}}� �
$num
}}� �
)
}}� �
)
}}� �
,
}}� �
Color
}}� �
.
}}� �
Black
}}� �
)
}}� �
Misc
�� 
.
�� 
DrawRectangle
�� "
(
��" #
_sb
��# &
,
��& '
New
��( +
	Rectangle
��, 5
(
��5 6
_parent
��6 =
.
��= >
Position
��> F
.
��F G
ToPoint
��G N
+
��O P
New
��Q T
Point
��U Z
(
��Z [
CInt
��[ _
(
��_ `
_parent
��` g
.
��g h
getTextureSize
��h v
.
��v w
X
��w x
*
��y z
ReloadCounter��{ �
/��� �

ReloadTime��� �
-��� �
$num��� �
)��� �
,��� �
-��� �
$num��� �
)��� �
,��� �
New��� �
Point��� �
(��� �
$num��� �
,��� �
$num��� �
)��� �
)��� �
,��� �
Color��� �
.��� �
Black��� �
)��� �
End
�� 
If
�� 
End
�� 
If
�� 
For
�� 
Each
�� 
_bul
�� 
In
�� 
Projectiles
�� $
_bul
�� 
.
�� 
Draw
�� 
(
�� 
_sb
�� 
)
�� 
Next
�� 
End
�� 
Sub
�� 
Public
�� 

Overridable
�� 
Sub
��  
OnProjectileImpact
�� -
(
��- .
ByRef
��. 3
sender
��4 :
As
��; =

Projectile
��> H
)
��H I
End
�� 
Sub
�� 
Dim
�� 
ReloadCounter
�� 
As
�� 
Integer
��  
=
��! "
$num
��# $
Public
�� 

Sub
�� 
ReloadWeapon
�� 
(
�� 
gameTime
�� $
As
��% '
GameTime
��( 0
)
��0 1
If
�� 

ReloadCounter
�� 
=
�� 
$num
�� 
Then
�� !

RaiseEvent
�� 
ReloadStarted
�� $
(
��$ %
)
��% &
End
�� 
If
�� 
If
�� 

ReloadCounter
�� 
>=
�� 

ReloadTime
�� &
Then
��' +
ReloadCounter
�� 
=
�� 
$num
�� 
ProjectilesInMag
�� 
=
�� 
ProjectilesMagMax
�� 0 
CurrentlyReloading
�� 
=
��  
False
��! &
Else
�� 
ReloadCounter
�� 
+=
�� 
CInt
�� !
(
��! "
gameTime
��" *
.
��* +
ElapsedGameTime
��+ :
.
��: ;
TotalMilliseconds
��; L
)
��L M 
CurrentlyReloading
�� 
=
��  
True
��! %
End
�� 
If
�� 
End
�� 
Sub
�� 
End�� 
Class
�� 	�8
\C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Dialogue\Dialogue.vb
Public 
Class 
Dialogue 
Public 

Segments 
As 
DialogueSegment &
(& '
)' (
Public 

Shared 
	SpeechBox 
As 
	Texture2D (
Dim 
KeyboardLastState 
As 
KeyboardState *
Dim  
DisplayingTextLength 
As 
Single  &
=' (
$num) -
Private 
_Active 
As 
Boolean 
=  
False! &
Public 

Property 
Active 
As 
Boolean %
Get 
Return 
_Active 
End 
Get 
Set 
( 
value 
As 
Boolean 
) 
_Active 
= 
value 
srcRect 
. 
Y 
= 
$num 
End 
Set 
End   
Property   
Private"" 
_SegmentIndex"" 
As"" 
Integer"" $
=""% &
$num""' (
Public## 

Property## 
SegmentIndex##  
As##! #
Integer##$ +
Get$$ 
Return%% 
_SegmentIndex%%  
End&& 
Get&& 
Set'' 
('' 
value'' 
As'' 
Integer'' 
)'' 
_SegmentIndex(( 
=(( 
value(( ! 
DisplayingTextLength))  
=))! "
$num))# $
End** 
Set** 
End++ 
Property++ 
Dim-- 
counter-- 
As-- 
Integer-- 
Public.. 

Sub.. 
Update.. 
(.. 
gameTime.. 
As.. !
GameTime.." *
)..* +
If// 

Active// 
Then// 
If00 
KeyboardLastState00  
.00  !
	IsKeyDown00! *
(00* +
Keys00+ /
.00/ 0
Space000 5
)005 6
AndAlso007 >
Keyboard00? G
.00G H
GetState00H P
.00P Q
IsKeyUp00Q X
(00X Y
Keys00Y ]
.00] ^
Space00^ c
)00c d
Then00e i
If11 
SegmentIndex11 
<11  !
Segments11" *
.11* +
Length11+ 1
-112 3
$num114 5
Then116 :
If22 
Segments22 
(22  
SegmentIndex22  ,
)22, -
.22- ."
DeactivateAfterSegment22. D
Then22E I
Active33 
=33  
False33! &
ScreenHandler44 %
.44% &
SelectedScreen44& 4
.444 5
ToWorld445 <
.44< =
Player44= C
.44C D
IsInDialogue44D P
=44Q R
False44S X
End55 
If55 
If77 
Segments77 
(77  
SegmentIndex77  ,
)77, -
.77- .
ResetAfterSegment77. ?
Then77@ D
SegmentIndex99 $
=99% &
$num99' (
Else:: 
SegmentIndex<< $
+=<<% '
$num<<( )
End== 
If== 
Else?? 
ScreenHandlerAA !
.AA! "
SelectedScreenAA" 0
.AA0 1
ToWorldAA1 8
.AA8 9
PlayerAA9 ?
.AA? @
IsInDialogueAA@ L
=AAM N
FalseAAO T
ActiveBB 
=BB 
FalseBB "
SegmentIndexDD  
=DD! "
$numDD# $
EndEE 
IfEE 
EndFF 
IfFF 
IfII 
srcRectII 
.II 
YII 
<II 
$numII 
AndAlsoII  '
counterII( /
>II0 1
$numII2 4
ThenII5 9
srcRectJJ 
.JJ 
YJJ 
+=JJ 
$numJJ  
EndKK 
IfKK 
EndLL 
IfLL 
IfOO 
 
DisplayingTextLengthOO 
<OO  !
SegmentsOO" *
(OO* +
SegmentIndexOO+ 7
)OO7 8
.OO8 9
TextOO9 =
.OO= >
LengthOO> D
AndAlsoOOE L
srcRectOOM T
.OOT U
YOOU V
=OOW X
$numOOY ]
ThenOO^ b 
DisplayingTextLengthPP  
+=PP! #
CSngPP$ (
(PP( )
$numPP) .
*PP/ 0
gameTimePP1 9
.PP9 :
ElapsedGameTimePP: I
.PPI J
TotalSecondsPPJ V
)PPV W
EndQQ 
IfQQ 
IfSS 

counterSS 
>SS 
$numSS 
ThenSS 
counterTT 
=TT 
$numTT 
EndUU 
IfUU 
counterVV 
+=VV 
CIntVV 
(VV 
gameTimeVV  
.VV  !
ElapsedGameTimeVV! 0
.VV0 1
TotalMillisecondsVV1 B
)VVB C
KeyboardLastStateWW 
=WW 
KeyboardWW $
.WW$ %
GetStateWW% -
EndXX 
SubXX 
DimZZ 
srcRectZZ 
AsZZ 
NewZZ 
	RectangleZZ  
(ZZ  !
$numZZ! "
,ZZ" #
$numZZ$ %
,ZZ% &
$numZZ' +
,ZZ+ ,
$numZZ- 0
)ZZ0 1
Public[[ 

Sub[[ 
Draw[[ 
([[ 
sb[[ 
As[[ 
SpriteBatch[[ %
)[[% &
If\\ 

Active\\ 
Then\\ 
sb]] 
.]] 
Draw]] 
(]] 
Segments]] 
(]] 
SegmentIndex]] )
)]]) *
.]]* +

FaceSprite]]+ 5
,]]5 6
New]]7 :
	Rectangle]]; D
(]]D E
$num]]E F
,]]F G
graphics]]H P
.]]P Q%
PreferredBackBufferHeight]]Q j
-]]k l
$num]]m p
,]]p q
$num]]r u
,]]u v
$num]]w z
)]]z {
,]]{ |
Color	]]} �
.
]]� �
White
]]� �
)
]]� �
sb__ 
.__ 
Draw__ 
(__ 
	SpeechBox__ 
,__ 
New__ "
	Rectangle__# ,
(__, -
$num__- 0
,__0 1
graphics__2 :
.__: ;%
PreferredBackBufferHeight__; T
-__U V
$num__W Z
,__Z [
graphics__\ d
.__d e$
PreferredBackBufferWidth__e }
-__~ 
$num
__� �
,
__� �
$num
__� �
)
__� �
,
__� �
srcRect
__� �
,
__� �
Color
__� �
.
__� �
White
__� �
)
__� �
Ifaa 
srcRectaa 
.aa 
Yaa 
=aa 
$numaa 
Thenaa  $
Enddd 
Ifdd 
Endee 
Ifee 
Endff 
Subff 
Endgg 
Classgg 	�
cC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Dialogue\DialogueSegment.vb
Public 
Class 
DialogueSegment 
Public 


FaceSprite 
As 
	Texture2D "
Public 

Text 
As 
String 
Public 
"
DeactivateAfterSegment !
As" $
Boolean% ,
=- .
False/ 4
Public 

ResetAfterSegment 
As 
Boolean  '
=( )
False* /
End		 
Class		 	�&
ZC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Graphics\Camera.vb
Public 
Class 
Camera 
Public 

Translation 
As 
New 
Vector3 %
(% &
$num& '
,' (
$num) *
,* +
$num, -
)- .
Public 

Scale 
As 
New 
Vector3 
(  
$num  !
,! "
$num# $
,$ %
$num& '
)' (
Public 

Function 
	GetMatrix 
( 
) 
As  "
Matrix# )
Return 
Matrix 
. 
CreateTranslation '
(' (
Translation( 3
)3 4
*5 6
Matrix		 
.		 
CreateTranslation		 (
(		( )
New		) ,
Vector3		- 4
(		4 5
$num		5 6
,		6 7
$num		8 ;
,		; <
$num		= >
)		> ?
)		? @
*		A B
Matrix

 
.

 
CreateScale

 "
(

" #
Scale

# (
)

( )
*

* +
Matrix 
. 
CreateScale "
(" #
CSng# '
(' (
graphics( 0
.0 1%
PreferredBackBufferHeight1 J
/K L
$numM Q
)Q R
)R S
*T U
Matrix 
. 
CreateTranslation (
(( )
New) ,
Vector3- 4
(4 5
CSng5 9
(9 :
graphics: B
.B C
GraphicsDeviceC Q
.Q R
ViewportR Z
.Z [
Width[ `
/a b
$numc d
)d e
,e f
CSngg k
(k l
graphicsl t
.t u
GraphicsDevice	u �
.
� �
Viewport
� �
.
� �
Height
� �
/
� �
$num
� �
)
� �
,
� �
$num
� �
)
� �
)
� �
End 
Function 
Public 

Function 
	GetMatrix 
( 
parallax &
As' )
Vector3* 1
)1 2
As3 5
Matrix6 <
Return 
Matrix 
. 
CreateTranslation '
(' (
Translation( 3
*4 5
New6 9
Vector3: A
(A B
$numB C
/D E
parallaxF N
.N O
XO P
,P Q
$numR S
,S T
$numU V
)V W
)W X
*Y Z
Matrix 
. 
CreateTranslation (
(( )
New) ,
Vector3- 4
(4 5
$num5 6
,6 7
$num8 ;
,; <
$num= >
)> ?
)? @
*A B
Matrix 
. 
CreateScale "
(" #
Scale# (
)( )
** +
Matrix 
. 
CreateScale "
(" #
CSng# '
(' (
graphics( 0
.0 1%
PreferredBackBufferHeight1 J
/K L
$numM Q
)Q R
)R S
*T U
Matrix 
. 
CreateTranslation (
(( )
New) ,
Vector3- 4
(4 5
CSng5 9
(9 :
graphics: B
.B C
GraphicsDeviceC Q
.Q R
ViewportR Z
.Z [
Width[ `
/a b
$numc d
)d e
,e f
CSngg k
(k l
graphicsl t
.t u
GraphicsDevice	u �
.
� �
Viewport
� �
.
� �
Height
� �
/
� �
$num
� �
)
� �
,
� �
$num
� �
)
� �
)
� �
End 
Function 
Public 

Sub 
FocusOnObject 
( 
obj  
As! #
Sprite$ *
)* +
Translation 
= 
New 
Vector3 !
(! "
-" #
obj# &
.& '
Position' /
,/ 0
$num1 2
)2 3
End 
Sub 
Public 

Sub 
FocusOnPosition 
( 
pos "
As# %
Vector2& -
)- .
Translation 
= 
New 
Vector3 !
(! "
-" #
pos# &
,& '
$num( )
)) *
End 
Sub 
End 
Class 	�(
iC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Graphics\ShadowOverlayRenderer.vb
Public 
Class !
ShadowOverlayRenderer "
Public 

Shared 
Sub 
RenderShadowOverlay )
() *
sb* ,
As- /
SpriteBatch0 ;
,; <
shadowOverlay= J
AsK M
RenderTarget2DN \
,\ ]
lightPolygons^ k
Asl n
Listo s
(s t
Oft v
Polygonw ~
)~ 
)	 �
graphics 
. 
GraphicsDevice 
.  
SetRenderTarget  /
(/ 0
shadowOverlay0 =
)= >
sb		 

.		
 
Begin		 
(		 
)		 
For

 
Each

 
p

 
In

 
lightPolygons

 #
p 
. 
DrawOutline 
( 
sb 
, 
False #
,# $
New% (
Color) .
(. /
$num/ 0
,0 1
$num2 3
,3 4
$num5 6
,6 7
$num8 9
)9 :
): ;
Next 
sb 

.
 
End 
( 
) 
For 
Each 
p 
In 
lightPolygons #
For 
i 
As 
Integer 
= 
$num  
To! #
p$ %
.% &
corners& -
.- .
Count. 3
-4 5
$num6 7
Dim 
v1 
As 
Vector2 !
=" #
p$ %
.% &
corners& -
(- .
i. /
)/ 0
-1 2
p3 4
.4 5
corners5 <
(< =
(= >
i> ?
+@ A
$numB C
)C D
ModE H
(I J
pJ K
.K L
cornersL S
.S T
CountT Y
-Z [
$num\ ]
)] ^
)^ _
Dim 
v2 
As 
Vector2 !
=" #
p$ %
.% &
corners& -
(- .
(. /
i/ 0
+1 2
$num3 4
)4 5
Mod6 9
(: ;
p; <
.< =
corners= D
.D E
CountE J
-K L
$numM N
)N O
)O P
-Q R
pS T
.T U
cornersU \
(\ ]
(] ^
i^ _
+` a
$numb c
)c d
Mode h
(i j
pj k
.k l
cornersl s
.s t
Countt y
-z {
$num| }
)} ~
)~ 
Dim 
dp 
= 
Vector2  
.  !
Dot! $
($ %
v1% '
,' (
v2) +
)+ ,
Dim 
angle 
= 
( 
dp 
/  !
(" #
v1# %
.% &
Length& ,
*- .
v2/ 1
.1 2
Length2 8
)8 9
)9 :
If 
angle 
< 
$num 
AndAlso $
angle% *
>+ ,
-- .
Math. 2
.2 3
PI3 5
/6 7
$num8 9
Then: >
Dim 
vm 
As 
New !
Vector2" )
() *
(* +
-+ ,
v1, .
.. /
X/ 0
+1 2
v23 5
.5 6
X6 7
)7 8
/9 :
$num; <
,< =
(> ?
-? @
v1@ B
.B C
YC D
+E F
v2G I
.I J
YJ K
)K L
/M N
$numO P
)P Q
Dim!! 
pointInP!!  
As!!! #
Vector2!!$ +
=!!, -
p!!. /
.!!/ 0
corners!!0 7
(!!7 8
(!!8 9
i!!9 :
+!!; <
$num!!= >
)!!> ?
Mod!!@ C
(!!D E
p!!E F
.!!F G
corners!!G N
.!!N O
Count!!O T
-!!U V
$num!!W X
)!!X Y
)!!Y Z
-!![ \
(!!] ^
vm!!^ `
/!!a b
$num!!c d
)!!d e
Misc## 
.## 
	FloodFill## "
(##" #
shadowOverlay### 0
,##0 1
pointInP##2 :
.##: ;
ToPoint##; B
)##B C
Exit$$ 
For$$ 
End%% 
If%% 
Next'' 
Next(( 
graphics** 
.** 
GraphicsDevice** 
.**  
SetRenderTarget**  /
(**/ 0
Nothing**0 7
)**7 8
End++ 
Sub++ 
End,, 
Class,, 	�
nC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ResourceHandling\FontHandling\Fonts.vb
Public 
Class 
Fonts 
Public 

Class 
ChakraPetch 
Public 
Shared 
Normal 
As 

SpriteFont  *
Public 
Shared 

ExtraLarge  
As! #

SpriteFont$ .
End 
Class 
Public

 

Shared

 
Sub

 
LoadContent

 !
(

! "
content

" )
As

* ,
ContentManager

- ;
)

; <
ChakraPetch 
. 

ExtraLarge 
=  
content! (
.( )
Load) -
(- .
Of. 0

SpriteFont1 ;
); <
(< =
$str= g
)g h
End 
Sub 
End 
Class 	�
{C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ResourceHandling\SoundSystem\ExtendedSoundEffect.vb
Public 
Class 
ExtendedSoundEffect  
Public 

SoundEffect 
As 
SoundEffect %
Public 

BeeperNotes 
As 
Note 
( 
)  
End 
Class 	�H
lC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ResourceHandling\SoundSystem\Note.vb
Public 
Class 
Note 
Public 

Pitch 
As 
Integer 
Public 

Duration 
As 
Integer 
Public 

Class 
Pitches 
Const 
C0 
As 
Integer 
= 
$num  
Const 
Cis0 
As 
Integer 
= 
$num  "
Const 
D0 
As 
Integer 
= 
$num  
Const		 
Dis0		 
As		 
Integer		 
=		 
$num		  "
Const

 
E0

 
As

 
Integer

 
=

 
$num

  
Const 
F0 
As 
Integer 
= 
$num  
Const 
Fis0 
As 
Integer 
= 
$num  "
Const 
G0 
As 
Integer 
= 
$num  
Const 
Gis0 
As 
Integer 
= 
$num  "
Const 
A0 
As 
Integer 
= 
$num  
Const 
Ais0 
As 
Integer 
= 
$num  "
Const 
B0 
As 
Integer 
= 
$num  
Const 
C1 
As 
Integer 
= 
$num  
Const 
Cis1 
As 
Integer 
= 
$num  "
Const 
D1 
As 
Integer 
= 
$num  
Const 
Dis1 
As 
Integer 
= 
$num  "
Const 
E1 
As 
Integer 
= 
$num  
Const 
F1 
As 
Integer 
= 
$num  
Const 
Fis1 
As 
Integer 
= 
$num  "
Const 
G1 
As 
Integer 
= 
$num  
Const 
Gis1 
As 
Integer 
= 
$num  "
Const 
A1 
As 
Integer 
= 
$num  
Const 
Ais1 
As 
Integer 
= 
$num  "
Const 
B1 
As 
Integer 
= 
$num  
Const   
C2   
As   
Integer   
=   
$num    
Const!! 
Cis2!! 
As!! 
Integer!! 
=!! 
$num!!  "
Const"" 
D2"" 
As"" 
Integer"" 
="" 
$num""  
Const## 
Dis2## 
As## 
Integer## 
=## 
$num##  "
Const$$ 
E2$$ 
As$$ 
Integer$$ 
=$$ 
$num$$  
Const%% 
F2%% 
As%% 
Integer%% 
=%% 
$num%%  
Const&& 
Fis2&& 
As&& 
Integer&& 
=&& 
$num&&  "
Const'' 
G2'' 
As'' 
Integer'' 
='' 
$num''  
Const(( 
Gis2(( 
As(( 
Integer(( 
=(( 
$num((  #
Const)) 
A2)) 
As)) 
Integer)) 
=)) 
$num)) !
Const** 
Ais2** 
As** 
Integer** 
=** 
$num**  #
Const++ 
B2++ 
As++ 
Integer++ 
=++ 
$num++ !
Const-- 
C3-- 
As-- 
Integer-- 
=-- 
$num-- !
Const.. 
Cis3.. 
As.. 
Integer.. 
=.. 
$num..  #
Const// 
D3// 
As// 
Integer// 
=// 
$num// !
Const00 
Dis300 
As00 
Integer00 
=00 
$num00  #
Const11 
E311 
As11 
Integer11 
=11 
$num11 !
Const22 
F322 
As22 
Integer22 
=22 
$num22 !
Const33 
Fis333 
As33 
Integer33 
=33 
$num33  #
Const44 
G344 
As44 
Integer44 
=44 
$num44 !
Const55 
Gis355 
As55 
Integer55 
=55 
$num55  #
Const66 
A366 
As66 
Integer66 
=66 
$num66 !
Const77 
Ais377 
As77 
Integer77 
=77 
$num77  #
Const88 
B388 
As88 
Integer88 
=88 
$num88 !
Const:: 
C4:: 
As:: 
Integer:: 
=:: 
$num:: !
Const;; 
Cis4;; 
As;; 
Integer;; 
=;; 
$num;;  #
Const<< 
D4<< 
As<< 
Integer<< 
=<< 
$num<< !
Const== 
Dis4== 
As== 
Integer== 
=== 
$num==  #
Const>> 
E4>> 
As>> 
Integer>> 
=>> 
$num>> !
Const?? 
F4?? 
As?? 
Integer?? 
=?? 
$num?? !
Const@@ 
Fis4@@ 
As@@ 
Integer@@ 
=@@ 
$num@@  #
ConstAA 
G4AA 
AsAA 
IntegerAA 
=AA 
$numAA !
ConstBB 
Gis4BB 
AsBB 
IntegerBB 
=BB 
$numBB  #
ConstCC 
A4CC 
AsCC 
IntegerCC 
=CC 
$numCC !
ConstDD 
Ais4DD 
AsDD 
IntegerDD 
=DD 
$numDD  #
ConstEE 
B4EE 
AsEE 
IntegerEE 
=EE 
$numEE !
ConstGG 
C5GG 
AsGG 
IntegerGG 
=GG 
$numGG !
ConstHH 
Cis5HH 
AsHH 
IntegerHH 
=HH 
$numHH  #
ConstII 
D5II 
AsII 
IntegerII 
=II 
$numII !
ConstJJ 
Dis5JJ 
AsJJ 
IntegerJJ 
=JJ 
$numJJ  #
ConstKK 
E5KK 
AsKK 
IntegerKK 
=KK 
$numKK !
ConstLL 
F5LL 
AsLL 
IntegerLL 
=LL 
$numLL !
ConstMM 
Fis5MM 
AsMM 
IntegerMM 
=MM 
$numMM  #
ConstNN 
G5NN 
AsNN 
IntegerNN 
=NN 
$numNN !
ConstOO 
Gis5OO 
AsOO 
IntegerOO 
=OO 
$numOO  #
ConstPP 
A5PP 
AsPP 
IntegerPP 
=PP 
$numPP !
ConstQQ 
Ais5QQ 
AsQQ 
IntegerQQ 
=QQ 
$numQQ  #
ConstRR 
B5RR 
AsRR 
IntegerRR 
=RR 
$numRR !
ConstTT 
C6TT 
AsTT 
IntegerTT 
=TT 
$numTT "
ConstUU 
Cis6UU 
AsUU 
IntegerUU 
=UU 
$numUU  $
ConstVV 
D6VV 
AsVV 
IntegerVV 
=VV 
$numVV "
ConstWW 
Dis6WW 
AsWW 
IntegerWW 
=WW 
$numWW  $
ConstXX 
E6XX 
AsXX 
IntegerXX 
=XX 
$numXX "
ConstYY 
F6YY 
AsYY 
IntegerYY 
=YY 
$numYY "
ConstZZ 
Fis6ZZ 
AsZZ 
IntegerZZ 
=ZZ 
$numZZ  $
Const[[ 
G6[[ 
As[[ 
Integer[[ 
=[[ 
$num[[ "
Const\\ 
Gis6\\ 
As\\ 
Integer\\ 
=\\ 
$num\\  $
Const]] 
A6]] 
As]] 
Integer]] 
=]] 
$num]] "
Const^^ 
Ais6^^ 
As^^ 
Integer^^ 
=^^ 
$num^^  $
Const__ 
B6__ 
As__ 
Integer__ 
=__ 
$num__ "
Endaa 
Classaa 
Endbb 
Classbb 	�#
qC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ResourceHandling\SoundSystem\PCSpeaker.vb
Public 
Class 
	PCSpeaker 
Public 

Shared 
Sub 
BeepDuration "
(" #
freq# '
As( *
Integer+ 2
,2 3
time4 8
As9 ;
Integer< C
)C D
Dim 
div 
As 
Short 
= 
CShort !
(! "
$num" )
/* +
freq, 0
)0 1
Out32 
( 
$num 
, 
$num 
) 
Out32 
( 
$num 
, 
div 
) 
Out32		 
(		 
$num		 
,		 
div		 
>>		 
$num		 
)		 
Dim 
tmp 
= 
Inp32 
( 
$num 
) 
If 

tmp 
<> 
( 
tmp 
Or 
$num 
) 
Then !
Out32 
( 
$num 
, 
CShort 
( 
tmp "
Or# %
$num& '
)' (
)( )
End 
If 
tmp 
= 
CShort 
( 
Inp32 
( 
$num 
)  
And! $
$num% )
)) *
Out32 
( 
$num 
, 
tmp 
) 
End 
Sub 
Public 

Shared 
Sub 
Beep 
( 
freq 
As  "
Integer# *
)* +
Dim 
div 
As 
Short 
= 
CShort !
(! "
$num" )
/* +
freq, 0
)0 1
Out32 
( 
$num 
, 
$num 
) 
Out32 
( 
$num 
, 
div 
) 
Out32 
( 
$num 
, 
div 
>> 
$num 
) 
Dim 
tmp 
= 
Inp32 
( 
$num 
) 
If 

tmp 
<> 
( 
tmp 
Or 
$num 
) 
Then !
Out32 
( 
$num 
, 
CShort 
( 
tmp "
Or# %
$num& '
)' (
)( )
End 
If 
End   
Sub   
Public"" 

Shared"" 
Sub"" 
StopBeep"" 
("" 
)""  
Dim## 
tmp## 
=## 
CShort## 
(## 
Inp32## 
(## 
$num## #
)### $
And##% (
$num##) -
)##- .
Out32%% 
(%% 
$num%% 
,%% 
tmp%% 
)%% 
End&& 
Sub&& 
<(( 
	DllImport(( 
((( 
$str(( &
,((& '
CharSet((( /
:=((/ 1
CharSet((1 8
.((8 9
Auto((9 =
,((= >

EntryPoint((? I
:=((I K
$str((K R
)((R S
>((S T
Private)) 
Shared)) 
Sub)) 
Out32)) 
()) 
ByVal)) "
PortAddress))# .
As))/ 1
Short))2 7
,))7 8
ByVal))9 >
Data))? C
As))D F
Short))G L
)))L M
End** 
Sub** 
<,, 
	DllImport,, 
(,, 
$str,, &
,,,& '
CharSet,,( /
:=,,/ 1
CharSet,,1 8
.,,8 9
Auto,,9 =
,,,= >

EntryPoint,,? I
:=,,I K
$str,,K R
),,R S
>,,S T
Private-- 
Shared-- 
Function-- 
Inp32-- !
(--! "
ByVal--" '
PortAddress--( 3
As--4 6
Short--7 <
)--< =
As--> @
Short--A F
End.. 
Function.. 
End// 
Class// 	�
pC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ResourceHandling\SoundSystem\NoteSong.vb
Public 
Class 
NoteSong 
Public 

Tracks 
As 
New 
List 
( 
Of  
Track! &
)& '
End 
Class 	�
sC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ResourceHandling\SoundSystem\SoundSystem.vb
Public 
Class 
SoundSystem 
Public 

Shared 
BeepModeActivated #
As$ &
Boolean' .
=/ 0
False1 6
Private 
Shared 

WithEvents 
	BeepTimer '
As( *
New+ .
Windows/ 6
.6 7
Forms7 <
.< =
Timer= B
Public

 

Shared

 
Sub

 
Play

 
(

 
soundEffect

 &
As

' )
SoundEffect

* 5
)

5 6
If 

Not 
BeepModeActivated  
Then! %
soundEffect 
. 
CreateInstance &
.& '
Play' +
(+ ,
), -
Else 
	PCSpeaker 
. 
Beep 
( 
$num 
)  
	BeepTimer 
. 
Interval 
=  
$num! $
	BeepTimer 
. 
Start 
( 
) 
End 
If 
End 
Sub 
Private 
Shared 
Sub 
BeepTimer_Tick %
(% &
)& '
Handles( /
	BeepTimer0 9
.9 :
Tick: >
	PCSpeaker 
. 
StopBeep 
( 
) 
	BeepTimer 
. 
Stop 
( 
) 
End 
Sub 
End 
Class 	�
mC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ResourceHandling\SoundSystem\Track.vb
Public 
Class 
Track 
Public 

Notes 
As 
New 
List 
( 
Of 
Note  $
)$ %
End 
Class 	�
C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ResourceHandling\SoundSystem\XmlSound\XmlSoundParser.vb
Public 
Class 
XmlSoundParser 
Public 

Function 
ParseXmlFile  
(  !
filePath! )
As* ,
String- 3
)3 4
As5 7
NoteSong8 @
Dim 
root 
= 
XElement 
. 
Load  
(  !
filePath! )
)) *
Dim 

resultSong 
As 
New 
NoteSong &
For		 
Each		 
	trackEles		 
In		 
root		 "
.		" #
Elements		# +
(		+ ,
$str		, 3
)		3 4
Dim

 
tmpTrack

 
As

 
New

 
Track

  %
For 
Each 
noteEle 
In 
	trackEles  )
.) *
Elements* 2
(2 3
$str3 6
)6 7
tmpTrack 
. 
Notes 
. 
Add "
(" #
New# &
Note' +
(+ ,
), -
With. 2
{3 4
. 
Duration 
= 
CInt  $
($ %
noteEle% ,
., -
Element- 4
(4 5
$str5 8
)8 9
)9 :
,: ;
. 
Pitch 
= 
CInt !
(! "
noteEle" )
.) *
Element* 1
(1 2
$str2 5
)5 6
)6 7
} 
) 
Next 

resultSong 
. 
Tracks 
. 
Add !
(! "
tmpTrack" *
)* +
Next 
Return 

resultSong 
End 
Function 
End 
Class 	�
yC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ResourceHandling\TextureHandling\TextureLoader.vb
Public 
Class 
TextureLoader 
Public 

Shared 
Function 
Load 
(  
contentPath  +
As, .
String/ 5
)5 6
As7 9
	Texture2D: C
Dim 
p 
= 
contentPath 
& 
$str $
Dim 
fs 
= 
New 

FileStream 
(  
p  !
,! "
FileMode# +
.+ ,
Open, 0
)0 1
Dim 
tex 
= 
	Texture2D 
. 

FromStream &
(& '
graphics' /
./ 0
GraphicsDevice0 >
,> ?
fs@ B
)B C
fs		 

.		
 
Dispose		 
(		 
)		 
Return

 
tex

 
End 
Function 
End 
Class 	�	
wC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\UI\Button\ParallelogramButton.vb
Public 
Class 
ParallelogramButton  
Inherits 
Button 
Public 

	Overrides 
Sub 
Draw 
( 
sb  
As! #
SpriteBatch$ /
)/ 0
If 

Visible 
Then 
If		 
Checked		 
Then		 
End 
If 
If 
rect 
. 
Contains 
( 
Mouse "
." #
GetState# +
.+ ,
Position, 4
)4 5
Then6 :
If 
Mouse 
. 
GetState !
.! "

LeftButton" ,
=- .
ButtonState/ :
.: ;
Pressed; B
ThenC G
Else 
End 
If 
Else 
End 
If 
MyBase 
. 
Draw 
( 
sb 
) 
End 
If 
End 
Sub 
End 
Class 	�6
pC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\UI\Button\SimpleButton.vb
Public 
Class 
SimpleButton 
Inherits 
Button 
Public 

BackgroundColor 
As 
Color #
=$ %
Color& +
.+ ,
Gray, 0
Public

 

	Overrides

 
Sub

 
Draw

 
(

 
sb

  
As

! #
SpriteBatch

$ /
)

/ 0
If 

Visible 
Then 
If 
Checked 
Then 
Misc 
. 
DrawRectangle "
(" #
sb# %
,% &
New' *
	Rectangle+ 4
(4 5
rect5 9
.9 :
X: ;
-< =
$num> ?
,? @
rectA E
.E F
YF G
-H I
$numJ K
,K L
rectM Q
.Q R
WidthR W
+X Y
$numZ [
,[ \
rect] a
.a b
Heightb h
+i j
$numk l
)l m
,m n
Coloro t
.t u
Blueu y
)y z
End 
If 
If 
rect 
. 
Contains 
( 
Mouse "
." #
GetState# +
.+ ,
Position, 4
)4 5
Then6 :
If 
Mouse 
. 
GetState !
.! "

LeftButton" ,
=- .
ButtonState/ :
.: ;
Pressed; B
ThenC G
Misc 
. 
DrawRectangle &
(& '
sb' )
,) *
rect+ /
,/ 0
Misc1 5
.5 6
SubtractColors6 D
(D E
BackgroundColorE T
,T U
NewV Y
ColorZ _
(_ `
$num` b
,b c
$numd f
,f g
$numh j
)j k
)k l
)l m
Else 
Misc 
. 
DrawRectangle &
(& '
sb' )
,) *
rect+ /
,/ 0
Misc1 5
.5 6
SubtractColors6 D
(D E
BackgroundColorE T
,T U
NewV Y
ColorZ _
(_ `
$num` b
,b c
$numd f
,f g
$numh j
)j k
)k l
)l m
End 
If 
Else 
Misc 
. 
DrawRectangle "
(" #
sb# %
,% &
rect' +
,+ ,
BackgroundColor- <
)< =
End 
If 
Select   
Case   
TextAlignment   %
Case!! 

Alignments!! 
.!!  
Center!!  &
sb"" 
."" 

DrawString"" !
(""! "
Fonts""" '
.""' (
ChakraPetch""( 3
.""3 4
Normal""4 :
,"": ;
Text""< @
,""@ A
New""B E
Vector2""F M
(""M N
CSng""N R
(""R S
rect""S W
.""W X
X""X Y
+""Z [
rect""\ `
.""` a
Width""a f
/""g h
$num""i j
-""k l
Fonts""m r
.""r s
ChakraPetch""s ~
.""~ 
Normal	"" �
.
""� �
MeasureString
""� �
(
""� �
Text
""� �
)
""� �
.
""� �
X
""� �
/
""� �
$num
""� �
)
""� �
,
""� �
CSng
""� �
(
""� �
rect
""� �
.
""� �
Y
""� �
+
""� �
rect
""� �
.
""� �
Height
""� �
/
""� �
$num
""� �
-
""� �
Fonts
""� �
.
""� �
ChakraPetch
""� �
.
""� �
Normal
""� �
.
""� �
MeasureString
""� �
(
""� �
Text
""� �
)
""� �
.
""� �
Y
""� �
/
""� �
$num
""� �
)
""� �
)
""� �
,
""� �
Color
""� �
.
""� �
Black
""� �
)
""� �
Case## 

Alignments## 
.##  
Left##  $
sb$$ 
.$$ 

DrawString$$ !
($$! "
Fonts$$" '
.$$' (
ChakraPetch$$( 3
.$$3 4
Normal$$4 :
,$$: ;
Text$$< @
,$$@ A
New$$B E
Vector2$$F M
($$M N
rect$$N R
.$$R S
X$$S T
+$$U V
SidePadding$$W b
,$$b c
CSng$$d h
($$h i
rect$$i m
.$$m n
Y$$n o
+$$p q
rect$$r v
.$$v w
Height$$w }
/$$~ 
$num
$$� �
-
$$� �
Fonts
$$� �
.
$$� �
ChakraPetch
$$� �
.
$$� �
Normal
$$� �
.
$$� �
MeasureString
$$� �
(
$$� �
Text
$$� �
)
$$� �
.
$$� �
Y
$$� �
/
$$� �
$num
$$� �
)
$$� �
)
$$� �
,
$$� �
Color
$$� �
.
$$� �
Black
$$� �
)
$$� �
Case%% 

Alignments%% 
.%%  
Right%%  %
sb&& 
.&& 

DrawString&& !
(&&! "
Fonts&&" '
.&&' (
ChakraPetch&&( 3
.&&3 4
Normal&&4 :
,&&: ;
Text&&< @
,&&@ A
New&&B E
Vector2&&F M
(&&M N
rect&&N R
.&&R S
Right&&S X
-&&Y Z
Fonts&&[ `
.&&` a
ChakraPetch&&a l
.&&l m
Normal&&m s
.&&s t
MeasureString	&&t �
(
&&� �
Text
&&� �
)
&&� �
.
&&� �
X
&&� �
-
&&� �
SidePadding
&&� �
,
&&� �
CSng
&&� �
(
&&� �
rect
&&� �
.
&&� �
Y
&&� �
+
&&� �
rect
&&� �
.
&&� �
Height
&&� �
/
&&� �
$num
&&� �
-
&&� �
Fonts
&&� �
.
&&� �
ChakraPetch
&&� �
.
&&� �
Normal
&&� �
.
&&� �
MeasureString
&&� �
(
&&� �
Text
&&� �
)
&&� �
.
&&� �
Y
&&� �
/
&&� �
$num
&&� �
)
&&� �
)
&&� �
,
&&� �
Color
&&� �
.
&&� �
Black
&&� �
)
&&� �
End'' 
Select'' 
MyBase)) 
.)) 
Draw)) 
()) 
sb)) 
))) 
End** 
If** 
End++ 
Sub++ 
End,, 
Class,, 	�
rC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\UI\Button\TexturedButton.vb
Public 
Class 
TexturedButton 
Inherits 
Button 
Public 

TextureNormal 
As 
	Texture2D %
Public 

TextureHover 
As 
	Texture2D $
Public		 

TextureClicked		 
As		 
	Texture2D		 &
Public

 

TextureChecked

 
As

 
	Texture2D

 &
Public 

	Overrides 
Sub 
Draw 
( 
sb  
As! #
SpriteBatch$ /
)/ 0
If 

Visible 
Then 
If 
Checked 
Then 
sb 
. 
Draw 
( 
TextureChecked &
,& '
rect( ,
,, -
Color. 3
.3 4
White4 9
)9 :
End 
If 
If 
rect 
. 
Contains 
( 
Mouse "
." #
GetState# +
.+ ,
Position, 4
)4 5
Then6 :
If 
Mouse 
. 
GetState !
.! "

LeftButton" ,
=- .
ButtonState/ :
.: ;
Pressed; B
ThenC G
sb 
. 
Draw 
( 
TextureClicked *
,* +
rect, 0
,0 1
Color2 7
.7 8
White8 =
)= >
Else 
sb 
. 
Draw 
( 
TextureHover (
,( )
rect* .
,. /
Color0 5
.5 6
White6 ;
); <
End 
If 
Else 
sb 
. 
Draw 
( 
TextureNormal %
,% &
rect' +
,+ ,
Color- 2
.2 3
White3 8
)8 9
End 
If 
MyBase   
.   
Draw   
(   
sb   
)   
End!! 
If!! 
End"" 
Sub"" 
End## 
Class## 	�(
dC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\UI\InfoBox.vb
Public 
Class 
InfoBox 
Public 

Shared 
Texture 
As 
	Texture2D &
Public 

Shared 
ReadOnly 
Property #
Active$ *
As+ -
Boolean. 5
=6 7
False8 =
Shared 

Text 
As 
String 
Public

 

Shared

 
BoxRT

 
As

 
New

 
RenderTarget2D

 -
(

- .
graphics

. 6
.

6 7
GraphicsDevice

7 E
,

E F
$num

G J
,

J K
$num

L O
)

O P
Public 

Shared 
Sub 
Show 
( 
_text  
As! #
String$ *
)* +
Text 
= 
_text 
_Active 
= 
True 
End 
Sub 
Shared 

Opacity 
As 
Single 
= 
$num #
Shared 

SpacePressedLast 
As 
Boolean &
=' (
False) .
Public 

Shared 
Sub 
DrawRT 
( 
sb 
As  "
SpriteBatch# .
,. /
gameTime0 8
As9 ;
GameTime< D
)D E
graphics 
. 
GraphicsDevice 
.  
SetRenderTarget  /
(/ 0
BoxRT0 5
)5 6
graphics 
. 
GraphicsDevice 
.  
Clear  %
(% &
Color& +
.+ ,
Transparent, 7
)7 8
sb 

.
 
Begin 
( 
) 
If 

Opacity 
> 
$num 
OrElse  
Active! '
Then( ,
sb 
. 
Draw 
( 
Texture 
, 
New  
	Rectangle! *
(* +
$num+ ,
,, -
$num. /
,/ 0
$num1 4
,4 5
$num6 9
)9 :
,: ;
Color< A
.A B
WhiteB G
)G H
If 
Active 
Then 
If 
Opacity 
< 
$num !
Then" &
Opacity   
+=   
CSng   #
(  # $
$num  $ (
*  ) *
gameTime  + 3
.  3 4
ElapsedGameTime  4 C
.  C D
TotalSeconds  D P
)  P Q
End!! 
If!! 
If## 
SpacePressedLast## #
AndAlso##$ +
Keyboard##, 4
.##4 5
GetState##5 =
.##= >
IsKeyUp##> E
(##E F
Keys##F J
.##J K
Space##K P
)##P Q
Then##R V
_Active$$ 
=$$ 
False$$ #
End%% 
If%% 
SpacePressedLast''  
=''! "
Keyboard''# +
.''+ ,
GetState'', 4
.''4 5
	IsKeyDown''5 >
(''> ?
Keys''? C
.''C D
Space''D I
)''I J
Else(( 
Opacity)) 
+=)) 
CSng)) 
())  
-))  !
$num))! %
*))& '
gameTime))( 0
.))0 1
ElapsedGameTime))1 @
.))@ A
TotalSeconds))A M
)))M N
End** 
If** 
End++ 
If++ 
sb,, 

.,,
 
End,, 
(,, 
),, 
graphics-- 
.-- 
GraphicsDevice-- 
.--  
SetRenderTarget--  /
(--/ 0
Nothing--0 7
)--7 8
End.. 
Sub.. 
Public00 

Shared00 
Sub00 
Draw00 
(00 
sb00 
As00  
SpriteBatch00! ,
)00, -
sb11 

.11
 
Begin11 
(11 
)11 
sb22 

.22
 
Draw22 
(22 
BoxRT22 
,22 
New22 
	Rectangle22 $
(22$ %
CInt22% )
(22) *
graphics22* 2
.222 3$
PreferredBackBufferWidth223 K
/22L M
$num22N O
-22P Q
$num22R U
)22U V
,22V W
CInt22X \
(22\ ]
graphics22] e
.22e f%
PreferredBackBufferHeight22f 
/
22� �
$num
22� �
-
22� �
$num
22� �
)
22� �
,
22� �
$num
22� �
,
22� �
$num
22� �
)
22� �
,
22� �
Color
22� �
.
22� �
White
22� �
*
22� �
Opacity
22� �
)
22� �
sb33 

.33
 
End33 
(33 
)33 
End44 
Sub44 
End55 
Class55 	�
_C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Misc\GlobalVariables.vb
Module 
GlobalVariables 
Public 

graphics 
As !
GraphicsDeviceManager ,
Public 

Random 
As 
New 
Random 
End 
Module 
�O
OC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Main.vb
Public 
Class 
Main 
Inherits 
Game 
Private 
spriteBatch 
As 
SpriteBatch &
Dim 

TestWorld1 
As 
New 
World 
Dim 
MainMenu 
As 
New 
MainMenu  
Dim 
LoadingScreen 
As 
New 
LoadingScreen *
Dim 
LoadingThread 
As 
New 
	Threading &
.& '
Thread' -
(- .
	AddressOf. 7&
LoadWorldContentBackground8 R
)R S
Public 

Shared 
worldFilePath 
As  "
String# )
=* +
$str, .
Public 

Shared !
LoadWorldOnNextUpdate '
As( *
Boolean+ 2
=3 4
False5 :
Public 

Shared 
	BackColor 
As 
Color $
=% &
Color' ,
., -
CornflowerBlue- ;
Public 

Sub 
New 
( 
) 
MyBase 
. 
New 
( 
) 
graphics 
= 
New !
GraphicsDeviceManager ,
(, -
Me- /
)/ 0
Content 
. 
RootDirectory 
= 
$str  )
End   
Sub   
	Protected(( 
	Overrides(( 
Sub(( 

Initialize(( &
(((& '
)((' (
IsMouseVisible)) 
=)) 
True)) 
ScreenHandler++ 
.++ 
SelectedScreen++ $
=++% &
MainMenu++' /
Window-- 
.-- 
Position-- 
=-- 
New-- 
Point-- #
(--# $
$num--$ %
,--% &
$num--' (
)--( )
graphics// 
.// $
PreferredBackBufferWidth// )
=//* +
$num//, 0
graphics00 
.00 %
PreferredBackBufferHeight00 *
=00+ ,
$num00- 1
graphics11 
.11 
IsFullScreen11 
=11 
False11  %
graphics22 
.22 
ApplyChanges22 
(22 
)22 
MyBase44 
.44 

Initialize44 
(44 
)44 
End55 
Sub55 
	Protected;; 
	Overrides;; 
Sub;; 
LoadContent;; '
(;;' (
);;( )
spriteBatch== 
=== 
New== 
SpriteBatch== %
(==% &
GraphicsDevice==& 4
)==4 5
Fonts@@ 
.@@ 
ChakraPetch@@ 
.@@ 
Normal@@  
=@@! "
Content@@# *
.@@* +
Load@@+ /
(@@/ 0
Of@@0 2

SpriteFont@@3 =
)@@= >
(@@> ?
$str@@? e
)@@e f
LoadingScreenAA 
.AA 
LoadContentAA !
(AA! "
ContentAA" )
)AA) *
MainMenuBB 
.BB 
LoadContentBB 
(BB 
ContentBB $
)BB$ %
EndCC 
SubCC 
PrivateEE 
SubEE &
LoadWorldContentBackgroundEE *
(EE* +
)EE+ ,
InfoBoxFF 
.FF 
TextureFF 
=FF 
TextureLoaderFF '
.FF' (
LoadFF( ,
(FF, -
$strFF- K
)FFK L
DialogueHH 
.HH 
	SpeechBoxHH 
=HH 
TextureLoaderHH *
.HH* +
LoadHH+ /
(HH/ 0
$strHH0 P
)HHP Q
TexturesJJ 
.JJ 
LoadTexturesJJ 
(JJ 
ContentJJ %
)JJ% &
AnimationSetsLL 
.LL 
LoadContentLL !
(LL! "
ContentLL" )
)LL) *
SoundsNN 
.NN 

LoadSoundsNN 
(NN 
ContentNN !
)NN! "
FontsPP 
.PP 
LoadContentPP 
(PP 
ContentPP !
)PP! "

TestWorld1RR 
=RR 
WorldLoaderRR  
.RR  !
	LoadWorldRR! *
(RR* +
worldFilePathRR+ 8
,RR8 9
ContentRR: A
)RRA B

TestWorld1TT 
.TT 
LoadContentTT 
(TT 
ContentTT &
)TT& '

TestWorld1UU 
.UU 
SelectedLevelUU  
=UU! "

TestWorld1UU# -
.UU- .
LevelsUU. 4
(UU4 5
$numUU5 6
)UU6 7
ScreenHandlerWW 
.WW 
SelectedScreenWW $
=WW% &

TestWorld1WW' 1
EndXX 
SubXX 
	Protected^^ 
	Overrides^^ 
Sub^^ 
UnloadContent^^ )
(^^) *
)^^* +
End`` 
Sub`` 
Dimcc 
frameCountercc 
Ascc 
Integercc 
=cc  !
$numcc" #
Dimdd 
elapsedTimedd 
Asdd 
Singledd 
=dd 
$numdd  !
	Protectedff 
	Overridesff 
Subff 
Updateff "
(ff" #
gameTimeff# +
Asff, .
GameTimeff/ 7
)ff7 8
Ifgg 

Keyboardgg 
.gg 
GetStategg 
(gg 
)gg 
.gg 
	IsKeyDowngg (
(gg( )
Keysgg) -
.gg- .
Escapegg. 4
)gg4 5
Thengg6 :
Endhh 
Endii 
Ifii 
elapsedTimekk 
+=kk 
CSngkk 
(kk 
gameTimekk $
.kk$ %
ElapsedGameTimekk% 4
.kk4 5
TotalMillisecondskk5 F
)kkF G
Ifll 

elapsedTimell 
>ll 
$numll 
Thenll "
Windowmm 
.mm 
Titlemm 
=mm 
$strmm "
&mm# $
frameCountermm% 1
.mm1 2
ToStringmm2 :
elapsedTimenn 
=nn 
$numnn 
frameCounteroo 
=oo 
$numoo 
Endpp 
Ifpp 
Iftt 
!
LoadWorldOnNextUpdatett  
Thentt! %!
LoadWorldOnNextUpdateuu !
=uu" #
Falseuu$ )
LoadingThreadww 
.ww 
IsBackgroundww &
=ww' (
Trueww) -
LoadingThreadyy 
.yy 
Startyy 
(yy  
)yy  !
Endzz 
Ifzz 
If|| 

LoadingThread|| 
.|| 
IsAlive||  
Then||! %
LoadingScreen}} 
.}} 
Update}}  
(}}  !
gameTime}}! )
)}}) *
Else 
If
�� 
Not
�� 
InfoBox
�� 
.
�� 
Active
�� !
Then
��" &
ScreenHandler
�� 
.
�� 
Update
�� $
(
��$ %
gameTime
��% -
)
��- .
End
�� 
If
�� 
End
�� 
If
�� 
If
�� 

Keyboard
�� 
.
�� 
GetState
�� 
.
�� 
	IsKeyDown
�� &
(
��& '
Keys
��' +
.
��+ ,
OemComma
��, 4
)
��4 5
Then
��6 :
graphics
�� 
.
�� &
PreferredBackBufferWidth
�� -
=
��. /
$num
��0 4
graphics
�� 
.
�� '
PreferredBackBufferHeight
�� .
=
��/ 0
$num
��1 4
graphics
�� 
.
�� 
ApplyChanges
�� !
(
��! "
)
��" #
End
�� 
If
�� 
If
�� 

Keyboard
�� 
.
�� 
GetState
�� 
.
�� 
	IsKeyDown
�� &
(
��& '
Keys
��' +
.
��+ ,
	OemPeriod
��, 5
)
��5 6
Then
��7 ;
graphics
�� 
.
�� &
PreferredBackBufferWidth
�� -
=
��. /
$num
��0 4
graphics
�� 
.
�� '
PreferredBackBufferHeight
�� .
=
��/ 0
$num
��1 5
graphics
�� 
.
�� 
ApplyChanges
�� !
(
��! "
)
��" #
End
�� 
If
�� 
MyBase
�� 
.
�� 
Update
�� 
(
�� 
gameTime
�� 
)
�� 
End
�� 
Sub
�� 
	Protected
�� 
	Overrides
�� 
Sub
�� 
Draw
��  
(
��  !
gameTime
��! )
As
��* ,
GameTime
��- 5
)
��5 6
InfoBox
�� 
.
�� 
DrawRT
�� 
(
�� 
spriteBatch
�� "
,
��" #
gameTime
��$ ,
)
��, -
If
�� 

LoadingThread
�� 
.
�� 
IsAlive
��  
Then
��! %
GraphicsDevice
�� 
.
�� 
Clear
��  
(
��  !
Color
��! &
.
��& '
Black
��' ,
)
��, -
LoadingScreen
�� 
.
�� 
Draw
�� 
(
�� 
spriteBatch
�� *
)
��* +
Else
�� 
GraphicsDevice
�� 
.
�� 
Clear
��  
(
��  !
	BackColor
��! *
)
��* +
ScreenHandler
�� 
.
�� 
Draw
�� 
(
�� 
spriteBatch
�� *
)
��* +
End
�� 
If
�� 
InfoBox
�� 
.
�� 
Draw
�� 
(
�� 
spriteBatch
��  
)
��  !
frameCounter
�� 
+=
�� 
$num
�� 
MyBase
�� 
.
�� 
Draw
�� 
(
�� 
gameTime
�� 
)
�� 
End
�� 
Sub
�� 
End�� 
Class
�� 	�
TC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Misc\Misc.vb
Public 
Class 
Misc 
Shared 

dummyTexture 
As 
	Texture2D $
=% &
New' *
	Texture2D+ 4
(4 5
graphics5 =
.= >
GraphicsDevice> L
,L M
$numN O
,O P
$numQ R
)R S
Shared		 

Sub		 
New		 
(		 
)		 
dummyTexture

 
.

 
SetData

 
(

 
New

  
Color

! &
(

& '
)

' (
{

) *
Color

* /
.

/ 0
White

0 5
}

5 6
)

6 7
End 
Sub 
Public 

Shared 
Sub 
DrawRectangle #
(# $
sb$ &
As' )
SpriteBatch* 5
,5 6
destRect7 ?
As@ B
	RectangleC L
,L M
colorN S
AsT V
ColorW \
)\ ]
sb 

.
 
Draw 
( 
dummyTexture 
, 
destRect &
,& '
color( -
)- .
End 
Sub 
Public 

Shared 
Sub 
DrawRectangle #
(# $
sb$ &
As' )
SpriteBatch* 5
,5 6
destRect7 ?
As@ B
	RectangleC L
,L M
colorN S
AsT V
ColorW \
,\ ]
colorOutline^ j
Ask m
Colorn s
,s t
thicknessOutline	u �
As
� �
Integer
� �
)
� �
DrawRectangle   
(   
sb   
,   
destRect   "
,  " #
color  $ )
)  ) *
DrawRectangle!! 
(!! 
sb!! 
,!! 
New!! 
	Rectangle!! '
(!!' (
destRect!!( 0
.!!0 1
X!!1 2
,!!2 3
destRect!!4 <
.!!< =
Y!!= >
,!!> ?
destRect!!@ H
.!!H I
Width!!I N
,!!N O
thicknessOutline!!P `
)!!` a
,!!a b
colorOutline!!c o
)!!o p
DrawRectangle"" 
("" 
sb"" 
,"" 
New"" 
	Rectangle"" '
(""' (
destRect""( 0
.""0 1
X""1 2
,""2 3
destRect""4 <
.""< =
Y""= >
+""? @
destRect""A I
.""I J
Height""J P
-""Q R
thicknessOutline""S c
,""c d
destRect""e m
.""m n
Width""n s
,""s t
thicknessOutline	""u �
)
""� �
,
""� �
colorOutline
""� �
)
""� �
DrawRectangle## 
(## 
sb## 
,## 
New## 
	Rectangle## '
(##' (
destRect##( 0
.##0 1
X##1 2
,##2 3
destRect##4 <
.##< =
Y##= >
,##> ?
thicknessOutline##@ P
,##P Q
destRect##R Z
.##Z [
Height##[ a
)##a b
,##b c
colorOutline##d p
)##p q
DrawRectangle$$ 
($$ 
sb$$ 
,$$ 
New$$ 
	Rectangle$$ '
($$' (
destRect$$( 0
.$$0 1
X$$1 2
+$$3 4
destRect$$5 =
.$$= >
Width$$> C
-$$D E
thicknessOutline$$F V
,$$V W
destRect$$X `
.$$` a
Y$$a b
,$$b c
thicknessOutline$$d t
,$$t u
destRect$$v ~
.$$~ 
Height	$$ �
)
$$� �
,
$$� �
colorOutline
$$� �
)
$$� �
End%% 
Sub%% 
Public.. 

Shared.. 
Sub.. 
DrawOutline.. !
(..! "
sb.." $
As..% '
SpriteBatch..( 3
,..3 4
destRect..5 =
As..> @
	Rectangle..A J
,..J K
colorOutline..L X
As..Y [
Color..\ a
,..a b
thicknessOutline..c s
As..t v
Integer..w ~
)..~ 
DrawRectangle// 
(// 
sb// 
,// 
New// 
	Rectangle// '
(//' (
destRect//( 0
.//0 1
X//1 2
,//2 3
destRect//4 <
.//< =
Y//= >
,//> ?
destRect//@ H
.//H I
Width//I N
,//N O
thicknessOutline//P `
)//` a
,//a b
colorOutline//c o
)//o p
DrawRectangle00 
(00 
sb00 
,00 
New00 
	Rectangle00 '
(00' (
destRect00( 0
.000 1
X001 2
,002 3
destRect004 <
.00< =
Y00= >
+00? @
destRect00A I
.00I J
Height00J P
-00Q R
thicknessOutline00S c
,00c d
destRect00e m
.00m n
Width00n s
,00s t
thicknessOutline	00u �
)
00� �
,
00� �
colorOutline
00� �
)
00� �
DrawRectangle11 
(11 
sb11 
,11 
New11 
	Rectangle11 '
(11' (
destRect11( 0
.110 1
X111 2
,112 3
destRect114 <
.11< =
Y11= >
,11> ?
thicknessOutline11@ P
,11P Q
destRect11R Z
.11Z [
Height11[ a
)11a b
,11b c
colorOutline11d p
)11p q
DrawRectangle22 
(22 
sb22 
,22 
New22 
	Rectangle22 '
(22' (
destRect22( 0
.220 1
X221 2
+223 4
destRect225 =
.22= >
Width22> C
-22D E
thicknessOutline22F V
,22V W
destRect22X `
.22` a
Y22a b
,22b c
thicknessOutline22d t
,22t u
destRect22v ~
.22~ 
Height	22 �
)
22� �
,
22� �
colorOutline
22� �
)
22� �
End33 
Sub33 
Public<< 

Shared<< 
Sub<< 
DrawLine<< 
(<< 
sb<< !
As<<" $
SpriteBatch<<% 0
,<<0 1

startPoint<<2 <
As<<= ?
Vector2<<@ G
,<<G H
endPoint<<I Q
As<<R T
Vector2<<U \
,<<\ ]
color<<^ c
As<<d f
Color<<g l
)<<l m
Dim== 
edge== 
As== 
Vector2== 
=== 
endPoint== &
-==' (

startPoint==) 3
Dim?? 
angle?? 
As?? 
Single?? 
=?? 
CSng?? "
(??" #
Math??# '
.??' (
Atan2??( -
(??- .
edge??. 2
.??2 3
Y??3 4
,??4 5
edge??6 :
.??: ;
X??; <
)??< =
)??= >
sbHH 

.HH
 
DrawHH 
(HH 
dummyTextureHH 
,HH 
NewHH !
	RectangleHH" +
(HH+ ,
CIntHH, 0
(HH0 1

startPointHH1 ;
.HH; <
XHH< =
)HH= >
,HH> ?
CIntHH@ D
(HHD E

startPointHHE O
.HHO P
YHHP Q
)HHQ R
,HHR S
CIntHHT X
(HHX Y
edgeHHY ]
.HH] ^
LengthHH^ d
(HHd e
)HHe f
)HHf g
,HHg h
$numHHi j
)HHj k
,HHk l
NothingHHm t
,HHt u
colorHHv {
,HH{ |
angle	HH} �
,
HH� �
New
HH� �
Vector2
HH� �
(
HH� �
$num
HH� �
,
HH� �
$num
HH� �
)
HH� �
,
HH� �
SpriteEffectsII 
.II 
NoneII 
,II 
$numII 
)II 
EndKK 
SubKK 
PublicRR 

SharedRR 
FunctionRR 
ConvertToRbgRR '
(RR' (
ByValRR( -
hexColorRR. 6
AsRR7 9
StringRR: @
)RR@ A
AsRRB D
ColorRRE J
DimSS 
RedSS 
AsSS 
IntegerSS 
DimTT 
GreenTT 
AsTT 
IntegerTT 
DimUU 
BlueUU 
AsUU 
IntegerUU 
hexColorVV 
=VV 
ReplaceVV 
(VV 
hexColorVV #
,VV# $
$strVV% (
,VV( )
$strVV* ,
)VV, -
RedWW 
=WW 
CIntWW 
(WW 
$strWW 
&WW 
MidWW 
(WW 
hexColorWW &
,WW& '
$numWW( )
,WW) *
$numWW+ ,
)WW, -
)WW- .
GreenXX 
=XX 
CIntXX 
(XX 
$strXX 
&XX 
MidXX 
(XX  
hexColorXX  (
,XX( )
$numXX* +
,XX+ ,
$numXX- .
)XX. /
)XX/ 0
BlueYY 
=YY 
CIntYY 
(YY 
$strYY 
&YY 
MidYY 
(YY 
hexColorYY '
,YY' (
$numYY) *
,YY* +
$numYY, -
)YY- .
)YY. /
ReturnZZ 
NewZZ 
ColorZZ 
(ZZ 
RedZZ 
,ZZ 
GreenZZ #
,ZZ# $
BlueZZ% )
,ZZ) *
$numZZ+ .
)ZZ. /
End[[ 
Function[[ 
Publicbb 

Sharedbb 
Functionbb 
TextureTo2DArraybb +
(bb+ ,
texturebb, 3
Asbb4 6
	Texture2Dbb7 @
)bb@ A
AsbbB D
ColorbbE J
(bbJ K
,bbK L
)bbL M
Dimcc 
colors1Dcc 
Ascc 
Colorcc 
(cc 
)cc 
=cc  !
Newcc" %
Colorcc& +
(cc+ ,
texturecc, 3
.cc3 4
Widthcc4 9
*cc: ;
texturecc< C
.ccC D
HeightccD J
-ccK L
$numccM N
)ccN O
{ccP Q
}ccQ R
texturedd 
.dd 
GetDatadd 
(dd 
colors1Ddd  
)dd  !
Dimgg 
colors2Dgg 
Asgg 
Colorgg 
(gg 
,gg 
)gg  
=gg! "
Newgg# &
Colorgg' ,
(gg, -
texturegg- 4
.gg4 5
Widthgg5 :
-gg; <
$numgg= >
,gg> ?
texturegg@ G
.ggG H
HeightggH N
-ggO P
$numggQ R
)ggR S
{ggT U
}ggU V
Forhh 
xhh 
Ashh 
Integerhh 
=hh 
$numhh 
Tohh 
texturehh  '
.hh' (
Widthhh( -
-hh. /
$numhh0 1
Forii 
yii 
Asii 
Integerii 
=ii 
$numii  
Toii! #
textureii$ +
.ii+ ,
Heightii, 2
-ii3 4
$numii5 6
colors2Djj 
(jj 
xjj 
,jj 
yjj 
)jj 
=jj  
colors1Djj! )
(jj) *
xjj* +
+jj, -
yjj. /
*jj0 1
texturejj2 9
.jj9 :
Widthjj: ?
)jj? @
Nextkk 
Nextll 
Returnnn 
colors2Dnn 
Endoo 
Functionoo 
Public
�� 

Shared
�� 
Function
�� !
ScreenPosToWorldPos
�� .
(
��. /
	screenPos
��/ 8
As
��9 ;
Point
��< A
)
��A B
As
��C E
Vector2
��F M
Dim
�� 
camera
�� 
=
�� 
ScreenHandler
�� "
.
��" #
SelectedScreen
��# 1
.
��1 2
ToWorld
��2 9
.
��9 :
SelectedLevel
��: G
.
��G H
Camera
��H N
Dim
�� 
viewport
�� 
=
�� 
graphics
�� 
.
��  
GraphicsDevice
��  .
.
��. /
Viewport
��/ 7
Return
�� 
New
�� 
Vector2
�� 
(
�� 
CSng
�� 
(
��  
(
��  !
	screenPos
��! *
.
��* +
X
��+ ,
-
��- .
viewport
��/ 7
.
��7 8
Width
��8 =
/
��> ?
$num
��@ A
)
��A B
/
��C D
camera
��E K
.
��K L
Scale
��L Q
.
��Q R
X
��R S
-
��T U
camera
��V \
.
��\ ]
Translation
��] h
.
��h i
X
��i j
)
��j k
,
��k l
CSng
�� 
(
��  
(
��  !
	screenPos
��! *
.
��* +
Y
��+ ,
-
��- .
viewport
��/ 7
.
��7 8
Height
��8 >
/
��? @
$num
��A B
)
��B C
/
��D E
camera
��F L
.
��L M
Scale
��M R
.
��R S
Y
��S T
-
��U V
$num
��W Z
-
��[ \
camera
��] c
.
��c d
Translation
��d o
.
��o p
Y
��p q
)
��q r
)
��r s
End
�� 
Function
�� 
Public
�� 

Shared
�� 
Function
�� !
GetRandomArrayIndex
�� .
(
��. /
_arr
��/ 3
(
��3 4
)
��4 5
As
��6 8
Object
��9 ?
)
��? @
As
��A C
Integer
��D K
Dim
�� 
rand
�� 
As
�� 
New
�� 
Random
�� 
Return
�� 
rand
�� 
.
�� 
Next
�� 
(
�� 
$num
�� 
,
�� 
_arr
��  
.
��  !
	GetLength
��! *
(
��* +
$num
��+ ,
)
��, -
)
��- .
End
�� 
Function
�� 
Public
�� 

Shared
�� 
Function
�� 
SubtractColors
�� )
(
��) *
color1
��* 0
As
��1 3
Color
��4 9
,
��9 :
color2
��; A
As
��B D
Color
��E J
)
��J K
As
��L N
Color
��O T
Dim
�� 
returnColor
�� 
As
�� 
New
�� 
Color
�� $
If
�� 

CInt
�� 
(
�� 
color1
�� 
.
�� 
R
�� 
)
�� 
-
�� 
color2
�� "
.
��" #
R
��# $
>
��% &
$num
��' (
Then
��) -
returnColor
�� 
.
�� 
R
�� 
=
�� 
color1
�� "
.
��" #
R
��# $
-
��% &
color2
��' -
.
��- .
R
��. /
Else
�� 
returnColor
�� 
.
�� 
R
�� 
=
�� 
$num
�� 
End
�� 
If
�� 
If
�� 

CInt
�� 
(
�� 
color1
�� 
.
�� 
G
�� 
)
�� 
-
�� 
color2
�� "
.
��" #
G
��# $
>
��% &
$num
��' (
Then
��) -
returnColor
�� 
.
�� 
G
�� 
=
�� 
color1
�� "
.
��" #
G
��# $
-
��% &
color2
��' -
.
��- .
G
��. /
Else
�� 
returnColor
�� 
.
�� 
G
�� 
=
�� 
$num
�� 
End
�� 
If
�� 
If
�� 

CInt
�� 
(
�� 
color1
�� 
.
�� 
B
�� 
)
�� 
-
�� 
color2
�� "
.
��" #
B
��# $
>
��% &
$num
��' (
Then
��) -
returnColor
�� 
.
�� 
B
�� 
=
�� 
color1
�� "
.
��" #
B
��# $
-
��% &
color2
��' -
.
��- .
B
��. /
Else
�� 
returnColor
�� 
.
�� 
B
�� 
=
�� 
$num
�� 
End
�� 
If
�� 
If
�� 

CInt
�� 
(
�� 
color1
�� 
.
�� 
A
�� 
)
�� 
-
�� 
color2
�� "
.
��" #
A
��# $
>
��% &
$num
��' (
Then
��) -
returnColor
�� 
.
�� 
A
�� 
=
�� 
color1
�� "
.
��" #
A
��# $
-
��% &
color2
��' -
.
��- .
A
��. /
Else
�� 
returnColor
�� 
.
�� 
A
�� 
=
�� 
$num
�� 
End
�� 
If
�� 
Return
�� 
returnColor
�� 
End
�� 
Function
�� 
Public
�� 

Shared
�� 
Sub
�� 
	FloodFill
�� 
(
��  
rt
��  "
As
��# %
RenderTarget2D
��& 4
,
��4 5
point
��6 ;
As
��< >
Point
��? D
)
��D E
Throw
�� 
New
�� %
NotImplementedException
�� )
(
��) *
$str
��* o
)
��o p
Dim
�� 
colors
�� 
(
�� 
rt
�� 
.
�� 
Width
�� 
*
�� 
rt
��  
.
��  !
Height
��! '
)
��' (
As
��) +
Color
��, 1
rt
�� 

.
��
 
GetData
�� 
(
�� 
colors
�� 
)
�� 
Dim
�� 

coordStack
�� 
As
�� 
New
�� 
Stack
�� #
(
��# $
Of
��$ &
Point
��' ,
)
��, -

coordStack
�� 
.
�� 
Push
�� 
(
�� 
point
�� 
)
�� 
While
�� 

coordStack
�� 
.
�� 
Count
�� 
>
��  
$num
��! "
Dim
�� 
p
�� 
As
�� 
Point
�� 
=
�� 

coordStack
�� '
.
��' (
Pop
��( +
Try
�� 
If
�� 
colors
�� 
(
�� 
p
�� 
.
�� 
Y
�� 
*
�� 
rt
��  "
.
��" #
Width
��# (
+
��) *
p
��+ ,
.
��, -
X
��- .
)
��. /
=
��0 1
New
��2 5
Color
��6 ;
(
��; <
$num
��< =
,
��= >
$num
��? @
,
��@ A
$num
��B C
)
��C D
Then
��E I
colors
�� 
(
�� 
p
�� 
.
�� 
Y
�� 
*
��  
rt
��! #
.
��# $
Width
��$ )
+
��* +
p
��, -
.
��- .
X
��. /
)
��/ 0
=
��1 2
New
��3 6
Color
��7 <
(
��< =
$num
��= >
,
��> ?
$num
��@ A
,
��A B
$num
��C D
,
��D E
$num
��F G
)
��G H

coordStack
�� 
.
�� 
Push
�� #
(
��# $
p
��$ %
+
��& '
New
��( +
Point
��, 1
(
��1 2
$num
��2 3
,
��3 4
$num
��5 6
)
��6 7
)
��7 8

coordStack
�� 
.
�� 
Push
�� #
(
��# $
p
��$ %
+
��& '
New
��( +
Point
��, 1
(
��1 2
-
��2 3
$num
��3 4
,
��4 5
$num
��6 7
)
��7 8
)
��8 9

coordStack
�� 
.
�� 
Push
�� #
(
��# $
p
��$ %
+
��& '
New
��( +
Point
��, 1
(
��1 2
$num
��2 3
,
��3 4
-
��5 6
$num
��6 7
)
��7 8
)
��8 9

coordStack
�� 
.
�� 
Push
�� #
(
��# $
p
��$ %
+
��& '
New
��( +
Point
��, 1
(
��1 2
$num
��2 3
,
��3 4
$num
��5 6
)
��6 7
)
��7 8
End
�� 
If
�� 
Catch
�� 
ex
�� 
As
�� 
	Exception
�� !
End
�� 
Try
�� 
End
�� 
While
�� 
rt
�� 

.
��
 
SetData
�� 
(
�� 
colors
�� 
)
�� 
End
�� 
Sub
�� 
End�� 
Class
�� 	�!
WC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Misc\Polygon.vb
Public 
Class 
Polygon 
Public 

corners 
As 
New 
List 
( 
Of !
Vector2" )
)) *
Sub 
New 
( 
) 
End

 
Sub

 
Sub 
New 
( 
_rect 
As 
	Rectangle 
) 
corners 
. 
Add 
( 
_rect 
. 
Location "
." #
	ToVector2# ,
), -
corners 
. 
Add 
( 
New 
Vector2 
(  
_rect  %
.% &
Right& +
,+ ,
_rect- 2
.2 3
Top3 6
)6 7
)7 8
corners 
. 
Add 
( 
New 
Vector2 
(  
_rect  %
.% &
Right& +
,+ ,
_rect- 2
.2 3
Bottom3 9
)9 :
): ;
corners 
. 
Add 
( 
New 
Vector2 
(  
_rect  %
.% &
Left& *
,* +
_rect, 1
.1 2
Bottom2 8
)8 9
)9 :
End 
Sub 
Public 

Sub 
DrawOutline 
( 
sb 
As  
SpriteBatch! ,
,, -
_drawCorners. :
As; =
Boolean> E
,E F
ColorG L
AsM O
ColorP U
)U V
For 
i 
As 
Integer 
= 
$num 
To 
corners  '
.' (
Count( -
-. /
$num0 1
If 
i 
< 
corners 
. 
Count  
-! "
$num# $
Then% )
Misc 
. 
DrawLine 
( 
sb  
,  !
corners" )
() *
i* +
)+ ,
,, -
corners. 5
(5 6
i6 7
+8 9
$num: ;
); <
,< =
Color> C
)C D
Else 
Misc 
. 
DrawLine 
( 
sb  
,  !
corners" )
() *
i* +
)+ ,
,, -
corners. 5
(5 6
$num6 7
)7 8
,8 9
Color: ?
)? @
End 
If 
Next 
If 

_drawCorners 
Then 
For 
Each 
_corner 
In 
corners  '
Misc 
. 
DrawRectangle "
(" #
sb# %
,% &
New' *
	Rectangle+ 4
(4 5
_corner5 <
.< =
ToPoint= D
-E F
NewG J
PointK P
(P Q
$numQ R
,R S
$numT U
)U V
,V W
NewX [
Point\ a
(a b
$numb c
,c d
$nume f
)f g
)g h
,h i
Colorj o
)o p
Next 
End   
If   
End!! 
Sub!! 
Public## 

Sub## 
MovePolygon## 
(## 
_shift## !
As##" $
Vector2##% ,
)##, -
For$$ 
i$$ 
As$$ 
Integer$$ 
=$$ 
$num$$ 
To$$ 
corners$$  '
.$$' (
Count$$( -
-$$. /
$num$$0 1
corners%% 
(%% 
i%% 
)%% 
+=%% 
_shift%%  
Next&& 
End'' 
Sub'' 
End(( 
Class(( 	�

yC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ResourceHandling\TextureHandling\TextureObject.vb
Public 
Class 
TextureObject 
Public 

Name 
As 
String 
Public 

Texture 
As 
	Texture2D 
Public 
$
HasRandomTextureRotation #
As$ &
Boolean' .
=/ 0
False1 6
Public 

	IsFoliage 
As 
Boolean 
=  !
False" '
Sub 
New 
( 
ByRef 
_name 
As 
String !
,! "
ByRef# (
_texture) 1
As2 4
	Texture2D5 >
,> ?
_randtexrot@ K
AsL N
BooleanO V
,V W
_foliageX `
Asa c
Booleand k
)k l
Name 
= 
_name 
Texture 
= 
_texture $
HasRandomTextureRotation  
=! "
_randtexrot# .
	IsFoliage 
= 
_foliage 
End 
Sub 
End 
Class 	�
tC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ResourceHandling\TextureHandling\Textures.vb
Public 
Class 
Textures 
Public 

Shared 
Bullet 
As 
	Texture2D %
Public 

Shared 
ParticleSpark 
As  "
	Texture2D# ,
Public 

Shared 
Sun 
As 
	Texture2D "
Public 

Shared 
SkyGradient 
As  
	Texture2D! *
Public		 

Shared		 
Clouds		 
(		 
$num		 
)		 
As		 
	Texture2D		 (
Public 

Shared 
Sub 
LoadTextures "
(" #
Content# *
As+ -
ContentManager. <
)< =
Bullet 
= 
TextureLoader 
. 
Load #
(# $
$str$ =
)= >
ParticleSpark 
= 
TextureLoader %
.% &
Load& *
(* +
$str+ C
)C D
Sun 
= 
TextureLoader 
. 
Load  
(  !
$str! C
)C D
SkyGradient 
= 
TextureLoader #
.# $
Load$ (
(( )
$str) T
)T U
Clouds 
( 
$num 
) 
= 
TextureLoader !
.! "
Load" &
(& '
$str' S
)S T
Clouds 
( 
$num 
) 
= 
TextureLoader !
.! "
Load" &
(& '
$str' S
)S T
LoadingZone 
. 
NotificationTexture '
=( )
TextureLoader* 7
.7 8
Load8 <
(< =
$str= h
)h i
End 
Sub 
End 
Class 	�!
kC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Graphics\ParticleSystem\Particle.vb
Public 
Class 
Particle 
Inherits 
Sprite 
Public 

Velocity 
As 
Vector2 
Public 

LifetimeCounter 
As 
Integer %
Public		 

Lifetime		 
As		 
Integer		 
Public

 

Alive

 
As

 
Boolean

 
=

 
True

 "
Public 

Opacity 
As 
Single 
= 
$num  
Public 

FadeTime 
As 
Integer 
Public 

GravityAffected 
As 
Boolean %
=& '
True( ,
Sub 
New 
( 
_tex 
As 
	Texture2D 
, 
_pos #
As$ &
Vector2' .
,. /
_vel0 4
As5 7
Vector28 ?
,? @
_ltimeA G
AsH J
IntegerK R
,R S
_fTimeT Z
As[ ]
Integer^ e
)e f
Texture 
= 
_tex 
Position 
= 
_pos 
Velocity 
= 
_vel 
Lifetime 
= 
_ltime 
FadeTime 
= 
_fTime 
End 
Sub 
Public 

	Overrides 
Sub 
Update 
(  
gameTime  (
As) +
GameTime, 4
)4 5
LifetimeCounter 
+= 
CInt 
(  
gameTime  (
.( )
ElapsedGameTime) 8
.8 9
TotalMilliseconds9 J
)J K
If 

GravityAffected 
Then 
Velocity 
. 
Y 
+= 
CSng 
( 
$num !
*" #
gameTime$ ,
., -
ElapsedGameTime- <
.< =
TotalSeconds= I
)I J
End 
If 
Position 
+= 
Velocity 
* 
CSng #
(# $
gameTime$ ,
., -
ElapsedGameTime- <
.< =
TotalSeconds= I
)I J
If   

LifetimeCounter   
>   
Lifetime   %
Then  & *
Alive!! 
=!! 
False!! 
End"" 
If"" 
If$$ 

LifetimeCounter$$ 
>$$ 
Lifetime$$ %
-$$& '
FadeTime$$( 0
AndAlso$$1 8
FadeTime$$9 A
<>$$B D
$num$$E F
Then$$G K
Opacity%% 
+=%% 
-%% 
CSng%% 
(%% 
$num%% 
/%%  
FadeTime%%! )
*%%* +
gameTime%%, 4
.%%4 5
ElapsedGameTime%%5 D
.%%D E
TotalMilliseconds%%E V
)%%V W
End&& 
If&& 
End'' 
Sub'' 
Public)) 

	Overrides)) 
Sub)) 
Draw)) 
()) 
sb))  
As))! #
SpriteBatch))$ /
)))/ 0
sb** 

.**
 
Draw** 
(** 
Texture** 
,** 
New** 
	Rectangle** &
(**& '
Position**' /
.**/ 0
ToPoint**0 7
,**7 8
New**9 <
Point**= B
(**B C
CInt**C G
(**G H
Texture**H O
.**O P
Width**P U
***V W
Scale**X ]
)**] ^
,**^ _
CInt**` d
(**d e
Texture**e l
.**l m
Height**m s
***t u
Scale**v {
)**{ |
)**| }
)**} ~
,**~ 
Color
**� �
.
**� �
White
**� �
*
**� �
Opacity
**� �
)
**� �
End++ 
Sub++ 
End,, 
Class,, 	�*
qC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Graphics\ParticleSystem\ParticleSystem.vb
Public 
Class 
ParticleSystem 
Private		 
	Particles		 
As		 
New		 
List		 !
(		! "
Of		" $
Particle		% -
)		- .
Public 

PossibleTextures 
( 
) 
As  
	Texture2D! *
Public 

Position 
As 
Vector2 
Public 
"
ParticleVelocityLowest !
As" $
Point% *
Public 
#
ParticleVelocityHighest "
As# %
Point& +
Public 

ParticleLifetime 
As 
Integer &
=' (
$num) -
Public!! 

SpawnsPerSecond!! 
As!! 
Single!! $
=!!% &
$num!!' (
Public%% 

ParticleFadeTime%% 
As%% 
Integer%% &
=%%' (
$num%%) ,
Public)) 

Event)) 
ParticlesDespawned)) #
())# $
)))$ %
Private++ 
Rand++ 
As++ 
New++ 
Random++ 
Sub-- 
New-- 
(-- 
_pos-- 
As-- 
Vector2-- 
)-- 
Position.. 
=.. 
_pos.. 
End// 
Sub// 
Sub11 
New11 
(11 
)11 
End33 
Sub33 
Public55 

Sub55 
SpawnParticles55 
(55 
_amount55 %
As55& (
Integer55) 0
)550 1
For66 
i66 
As66 
Integer66 
=66 
$num66 
To66 
_amount66  '
Dim77 
randVelocity77 
As77 
Vector277  '
randVelocity88 
.88 
X88 
=88 
Rand88 !
.88! "
Next88" &
(88& '"
ParticleVelocityLowest88' =
.88= >
X88> ?
,88? @#
ParticleVelocityHighest88A X
.88X Y
X88Y Z
+88[ \
$num88] ^
)88^ _
randVelocity99 
.99 
Y99 
=99 
Rand99 !
.99! "
Next99" &
(99& '"
ParticleVelocityLowest99' =
.99= >
Y99> ?
,99? @#
ParticleVelocityHighest99A X
.99X Y
Y99Y Z
+99[ \
$num99] ^
)99^ _
	Particles:: 
.:: 
Add:: 
(:: 
New:: 
Particle:: &
(::& '
PossibleTextures::' 7
(::7 8
Misc::8 <
.::< =
GetRandomArrayIndex::= P
(::P Q
PossibleTextures::Q a
)::a b
)::b c
,::c d
Position::e m
,::m n
randVelocity::o {
,::{ |
ParticleLifetime	::} �
,
::� �
ParticleFadeTime
::� �
)
::� �
)
::� �
Next;; 
End<< 
Sub<< 
Public>> 

Sub>> 
Draw>> 
(>> 
sb>> 
As>> 
SpriteBatch>> %
)>>% &
For?? 
Each?? 
_par?? 
In?? 
	Particles?? "
_par@@ 
.@@ 
Draw@@ 
(@@ 
sb@@ 
)@@ 
NextAA 
EndBB 
SubBB 
DimDD 
intervalCounterDD 
AsDD 
IntegerDD "
=DD# $
$numDD% &
PublicEE 

SubEE 
UpdateEE 
(EE 
gameTimeEE 
AsEE !
GameTimeEE" *
)EE* +
IfFF 

SpawnsPerSecondFF 
<>FF 
$numFF 
ThenFF  $
DimGG 
spawnIntervalGG 
AsGG  
IntegerGG! (
=GG) *
CIntGG+ /
(GG/ 0
$numGG0 4
/GG5 6
SpawnsPerSecondGG7 F
)GGF G
intervalCounterJJ 
+=JJ 
CIntJJ #
(JJ# $
gameTimeJJ$ ,
.JJ, -
ElapsedGameTimeJJ- <
.JJ< =
TotalMillisecondsJJ= N
)JJN O
IfKK 
intervalCounterKK 
>=KK !
spawnIntervalKK" /
ThenKK0 4
SpawnParticlesLL 
(LL 
$numLL  
)LL  !
intervalCounterMM 
=MM  !
$numMM" #
EndNN 
IfNN 
EndOO 
IfOO 
ForRR 
EachRR 
_parRR 
InRR 
	ParticlesRR "
_parSS 
.SS 
UpdateSS 
(SS 
gameTimeSS  
)SS  !
NextTT 
	ParticlesVV 
.VV 
	RemoveAllVV 
(VV 
FunctionVV $
(VV$ %
xVV% &
)VV& '
xVV( )
.VV) *
AliveVV* /
=VV0 1
FalseVV2 7
)VV7 8
IfWW 

	ParticlesWW 
.WW 
CountWW 
=WW 
$numWW 
ThenWW #

RaiseEventXX 
ParticlesDespawnedXX )
(XX) *
)XX* +
EndYY 
IfYY 
EndZZ 
SubZZ 
End[[ 
Class[[ 	�
RC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Program.vb
Public 
NotInheritable 
Class 
Program #
Private 
Sub 
New 
( 
) 
End 
Sub 
< 
	STAThread 
> 
Friend 

Shared 
Sub 
Main 
( 
) 
Using 
game 
As 
New 
Main 
( 
)  
game 
. 
Run 
( 
) 
End 
Using 
End 
Sub 
End 
Class 	�
^C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\Properties\AssemblyInfo.vb
< 
Assembly 	
:	 

AssemblyTitle 
( 
$str .
). /
>/ 0
<		 
Assembly		 	
:			 

AssemblyProduct		 
(		 
$str		 0
)		0 1
>		1 2
<

 
Assembly

 	
:

	 
!
AssemblyConfiguration

  
(

  !
$str

! #
)

# $
>

$ %
< 
Assembly 	
:	 

AssemblyDescription 
( 
$str !
)! "
>" #
< 
Assembly 	
:	 

AssemblyCompany 
( 
$str 
) 
> 
< 
Assembly 	
:	 

AssemblyCopyright 
( 
$str 0
)0 1
>1 2
< 
Assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
>  !
< 
Assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
> 
< 
Assembly 	
:	 


ComVisible 
( 
False 
) 
> 
< 
Assembly 	
:	 

Guid 
( 
$str 6
)6 7
>7 8
<## 
Assembly## 	
:##	 

AssemblyVersion## 
(## 
$str## $
)##$ %
>##% &
<$$ 
Assembly$$ 	
:$$	 

AssemblyFileVersion$$ 
($$ 
$str$$ (
)$$( )
>$$) *�
`C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\Screen.vb
Public 
MustInherit 
Class 
Screen 
Public 

Overridable 
Sub 
Inititialize '
(' (
)( )
End 
Sub 
Public 

Overridable 
Sub 
Update !
(! "
gameTime" *
As+ -
GameTime. 6
)6 7
End		 
Sub		 
Public 

Overridable 
Sub 
Draw 
(  
sb  "
As# %
SpriteBatch& 1
)1 2
sb 

.
 
Begin 
( 
) 
sb 

.
 

DrawString 
( 
Fonts 
. 
ChakraPetch '
.' (
Normal( .
,. /
$str0 @
,@ A
NewB E
Vector2F M
(M N
$numN Q
,Q R
$numS V
)V W
,W X
ColorY ^
.^ _
Black_ d
)d e
sb 

.
 
End 
( 
) 
End 
Sub 
Public 

Function 
ToWorld 
( 
) 
As  
World! &
Return 

DirectCast 
( 
Me 
, 
World #
)# $
End 
Function 
End 
Class 	�
gC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\ScreenHandler.vb
Public 
Class 
ScreenHandler 
Shared 

_SelectedScreen 
As 
Screen $
Public 

Shared 
Property 
SelectedScreen )
As* ,
Screen- 3
Get 
Return		 
_SelectedScreen		 "
End

 
Get

 
Set 
( 
value 
As 
Screen 
) 
_SelectedScreen 
= 
value #$
InitializeSelectedScreen $
($ %
)% &
End 
Set 
End 
Property 
Shared 

Sub $
InitializeSelectedScreen '
(' (
)( )
If 

SelectedScreen 
IsNot 
Nothing  '
Then( ,
SelectedScreen 
. 
Inititialize '
(' (
)( )
End 
If 
End 
Sub 
Public 

Shared 
Sub 
Update 
( 
gameTime %
As& (
GameTime) 1
)1 2
If 

SelectedScreen 
IsNot 
Nothing  '
Then( ,
SelectedScreen 
. 
Update !
(! "
gameTime" *
)* +
End 
If 
End 
Sub 
Public 

Shared 
Sub 
Draw 
( 
sb 
As  
SpriteBatch! ,
), -
If 

SelectedScreen 
IsNot 
Nothing  '
Then( ,
SelectedScreen 
. 
Draw 
(  
sb  "
)" #
End   
If   
End!! 
Sub!! 
End"" 
Class"" 	�-
oC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\Screens\LoadingScreen.vb
Public 
Class 
LoadingScreen 
Inherits 
Screen 
Dim		 
Cassette		 
As		 
	Texture2D		 
Dim

 
CassetteReel

 
As

 
	Texture2D

 !
Dim 
TransparencyCounter 
As 
Integer &
=' (
-) *
$num* -
Dim 
ReelRoation 
As 
Single 
= 
$num  !
Public 

	Overrides 
Sub 
Update 
(  
gameTime  (
As) +
GameTime, 4
)4 5
ReelRoation 
+= 
CSng 
( 
$num 
* 
gameTime  (
.( )
ElapsedGameTime) 8
.8 9
TotalSeconds9 E
)E F
TransparencyCounter 
+= 
CInt #
(# $
gameTime$ ,
., -
ElapsedGameTime- <
.< =
TotalMilliseconds= N
)N O
End 
Sub 
Public 

	Overrides 
Sub 
Draw 
( 
sb  
As! #
SpriteBatch$ /
)/ 0
sb 

.
 
Begin 
( 
) 
Dim 
transparency 
As 
Single "
transparency 
= 
$num 
- 
CSng 
(  
TransparencyCounter  3
/4 5
$num6 9
)9 :
sb 

.
 
Draw 
( 
texture 
:= 
CassetteReel %
,% &
position  (
:=( *
New* -
Vector2. 5
(5 6
CSng6 :
(: ;
graphics; C
.C D$
PreferredBackBufferWidthD \
/] ^
$num_ `
-a b
$numc f
)f g
,g h
CSngi m
(m n
graphicsn v
.v w&
PreferredBackBufferHeight	w �
/
� �
$num
� �
+
� �
$num
� �
)
� �
)
� �
,
� �
rotation  (
:=( *
ReelRoation* 5
,5 6
origin    &
:=  & (
New  ( +
Vector2  , 3
(  3 4
$num  4 6
/  7 8
$num  9 :
,  : ;
$num  < >
/  ? @
$num  A B
)  B C
)  C D
sb"" 

.""
 
Draw"" 
("" 
texture"" 
:="" 
CassetteReel"" %
,""% &
position## $
:=##$ &
New##& )
Vector2##* 1
(##1 2
CSng##2 6
(##6 7
graphics##7 ?
.##? @$
PreferredBackBufferWidth##@ X
/##Y Z
$num##[ \
+##] ^
$num##_ b
)##b c
,##c d
CSng##e i
(##i j
graphics##j r
.##r s&
PreferredBackBufferHeight	##s �
/
##� �
$num
##� �
+
##� �
$num
##� �
)
##� �
)
##� �
,
##� �
rotation$$ $
:=$$$ &
ReelRoation$$& 1
+$$2 3
$num$$4 5
,$$5 6
origin%% "
:=%%" $
New%%$ '
Vector2%%( /
(%%/ 0
$num%%0 2
/%%3 4
$num%%5 6
,%%6 7
$num%%8 :
/%%; <
$num%%= >
)%%> ?
)%%? @
sb'' 

.''
 
Draw'' 
('' 
texture'' 
:='' 
Cassette'' !
,''! "
position(( $
:=(($ &
New((& )
Vector2((* 1
(((1 2
CSng((2 6
(((6 7
graphics((7 ?
.((? @$
PreferredBackBufferWidth((@ X
/((Y Z
$num(([ \
-((] ^
Cassette((_ g
.((g h
Width((h m
/((n o
$num((p q
)((q r
,((r s
CSng((t x
(((x y
graphics	((y �
.
((� �'
PreferredBackBufferHeight
((� �
/
((� �
$num
((� �
-
((� �
Cassette
((� �
.
((� �
Height
((� �
/
((� �
$num
((� �
)
((� �
)
((� �
)
((� �
Misc,, 
.,, 
DrawRectangle,, 
(,, 
sb,, 
,,, 
New,, "
	Rectangle,,# ,
(,,, -
$num,,- .
,,,. /
$num,,0 1
,,,1 2
graphics,,3 ;
.,,; <$
PreferredBackBufferWidth,,< T
,,,T U
graphics,,V ^
.,,^ _%
PreferredBackBufferHeight,,_ x
),,x y
,,,y z
Color	,,{ �
.
,,� �
Black
,,� �
*
,,� �
transparency
,,� �
)
,,� �
sb// 

.//
 
End// 
(// 
)// 
End11 
Sub11 
Public33 

Sub33 
LoadContent33 
(33 
Content33 "
As33# %
ContentManager33& 4
)334 5
Cassette44 
=44 
TextureLoader44  
.44  !
Load44! %
(44% &
$str44& F
)44F G
CassetteReel55 
=55 
TextureLoader55 $
.55$ %
Load55% )
(55) *
$str55* O
)55O P
End66 
Sub66 
End77 
Class77 	�
jC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\Screens\MainMenu.vb
Public 
Class 
MainMenu 
Inherits 
Screen 
Dim

 

WithEvents

 
btnLoadWorld

 
As

  "
New

# &
TexturedButton

' 5
With

6 :
{

; <
. 	
rect	 
= 
New 
	Rectangle 
( 
$num !
,! "
$num# &
,& '
$num( +
,+ ,
$num- 0
)0 1
,1 2
. 	
TextAlignment	 
= 
Button 
.  

Alignments  *
.* +
Left+ /
,/ 0
. 	
SidePadding	 
= 
$num 
} 
Public 

	Overrides 
Sub 
Inititialize %
(% &
)& '
End 
Sub 
Public 

Sub 
LoadContent 
( 
Content "
As# %
ContentManager& 4
)4 5
btnLoadWorld 
. 
TextureNormal "
=# $
TextureLoader% 2
.2 3
Load3 7
(7 8
$str8 a
)a b
btnLoadWorld 
. 
TextureHover !
=" #
TextureLoader$ 1
.1 2
Load2 6
(6 7
$str7 f
)f g
btnLoadWorld 
. 
TextureClicked #
=$ %
btnLoadWorld& 2
.2 3
TextureHover3 ?
End 
Sub 
Public 

	Overrides 
Sub 
Update 
(  
gameTime  (
As) +
GameTime, 4
)4 5
End 
Sub 
Public 

	Overrides 
Sub 
Draw 
( 
sb  
As! #
SpriteBatch$ /
)/ 0
sb 

.
 
Begin 
( 
) 
btnLoadWorld!! 
.!! 
Draw!! 
(!! 
sb!! 
)!! 
sb## 

.##
 
End## 
(## 
)## 
End$$ 
Sub$$ 
Private'' 
Sub'' 
btnLoadWorld_Click'' "
(''" #
)''# $
Handles''% ,
btnLoadWorld''- 9
.''9 :
Click'': ?
Main00 
.00 
worldFilePath00 
=00 
	Directory00 &
.00& '
GetCurrentDirectory00' :
&00; <
$str00= Q
Main11 
.11 !
LoadWorldOnNextUpdate11 "
=11# $
True11% )
End22 
Sub22 
End44 
Class44 	�

lC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\Screens\TestScreen.vb
Public 
Class 

TestScreen 
Inherits 
Screen 
Public 

	Overrides 
Sub 
Inititialize %
(% &
)& '
MsgBox 
( 
$str '
)' (
End		 
Sub		 
Public 

	Overrides 
Sub 
Update 
(  
gameTime  (
As) +
GameTime, 4
)4 5
Diagnostics 
. 
Debug 
. 
	WriteLine #
(# $
$str$ <
&= >
gameTime? G
.G H
ElapsedGameTimeH W
.W X
MillisecondsX d
&e f
$strg v
)v w
End 
Sub 
Public 

	Overrides 
Sub 
Draw 
( 
sb  
As! #
SpriteBatch$ /
)/ 0
sb 

.
 
Begin 
( 
) 
sb 

.
 
End 
( 
) 
End 
Sub 
End 
Class 	� 
jC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\UI\Button\Button.vb
Public 
MustInherit 
Class 
Button 
Inherits 
	UIElement 
Public 

Event 
Click 
( 
sender 
As  
Object! '
)' (
Public		 

Event		 

MouseEnter		 
(		 
sender		 "
As		# %
Object		& ,
)		, -
Public

 

Event

 

MouseLeave

 
(

 
sender

 "
As

# %
Object

& ,
)

, -
Public 

Text 
As 
String 
= 
$str 
Public 

ToggleButton 
As 
Boolean "
=# $
False% *
Public 

Checked 
As 
Boolean 
= 
False  %
Public 

Enabled 
As 
Boolean 
= 
True  $
Public 

TextAlignment 
As 

Alignments &
Public 

SidePadding 
As 
Integer !
=" #
$num$ %
Public 

Enum 

Alignments 
Left 
Center 
Right 
End 
Enum 
Sub 
New 
( 
) 
Visible 
= 
True 
End 
Sub 
Dim 
MouseLastState 
As 

MouseState $
Public 

	Overrides 
Sub 
Draw 
( 
sb  
As! #
SpriteBatch$ /
)/ 0
If   

Enabled   
Then   #
DetectButtonInteraction!! #
(!!# $
)!!$ %
End"" 
If"" 
MouseLastState$$ 
=$$ 
Mouse$$ 
.$$ 
GetState$$ '
End%% 
Sub%% 
Private'' 
Sub'' #
DetectButtonInteraction'' '
(''' (
)''( )
If(( 

rect(( 
.(( 
Contains(( 
((( 
Mouse(( 
.(( 
GetState(( '
.((' (
Position((( 0
)((0 1
Then((2 6
If)) 
Mouse)) 
.)) 
GetState)) 
.)) 

LeftButton)) (
=))) *
ButtonState))+ 6
.))6 7
Pressed))7 >
AndAlso))? F
MouseLastState))G U
.))U V

LeftButton))V `
=))a b
ButtonState))c n
.))n o
Released))o w
Then))x |

RaiseEvent** 
Click**  
(**  !
Me**! #
)**# $
If-- 
ToggleButton-- 
Then--  $
Checked.. 
=.. 
Not.. !
Checked.." )
End// 
If// 
End00 
If00 
If22 
Not22 
rect22 
.22 
Contains22  
(22  !
MouseLastState22! /
.22/ 0
Position220 8
)228 9
Then22: >

RaiseEvent33 

MouseEnter33 %
(33% &
Me33& (
)33( )
End44 
If44 
End55 
If55 
If88 

rect88 
.88 
Contains88 
(88 
MouseLastState88 '
.88' (
Position88( 0
)880 1
AndAlso882 9
Not88: =
rect88> B
.88B C
Contains88C K
(88K L
Mouse88L Q
.88Q R
GetState88R Z
.88Z [
Position88[ c
)88c d
Then88e i

RaiseEvent99 

MouseLeave99 !
(99! "
Me99" $
)99$ %
End:: 
If:: 
End;; 
Sub;; 
End<< 
Class<< 	�
fC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\UI\UIElement.vb
Public 
MustInherit 
Class 
	UIElement "
Public 

rect 
As 
New 
	Microsoft  
.  !
Xna! $
.$ %
	Framework% .
.. /
	Rectangle/ 8
(8 9
$num9 :
,: ;
$num< =
,= >
$num? @
,@ A
$numB C
)C D
Public 

Visible 
As 
Boolean 
Public 

srcRect 
As 
	Microsoft 
.  
Xna  #
.# $
	Framework$ -
.- .
	Rectangle. 7
Public 

MustOverride 
Sub 
Draw  
(  !
sb! #
As$ &
	Microsoft' 0
.0 1
Xna1 4
.4 5
	Framework5 >
.> ?
Graphics? G
.G H
SpriteBatchH S
)S T
End 
Class 	�
�C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\WorldHandling\LevelHandling\LevelSpecificCode\LevelSpecificCode.vb
	Namespace 	
LevelSpecificCode
 
Public 

Class 
LevelSpecificCode "
Shared 
LevelCodeClass 
As  %
LevelSpecificCodeTemplate! :
Public

 
Shared

 
Sub

 
SetCurrentLevel

 )
(

) *
level

* /
As

0 2
Level

3 8
,

8 9
props

: ?
As

@ B
List

C G
(

G H
Of

H J
WorldObject

K V
)

V W
)

W X
Select 
Case 
level 
. 
Name "
Case 
$str  
LevelCodeClass "
=# $
New% (
Levels) /
./ 0
	IntroCity0 9
(9 :
level: ?
,? @
propsA F
)F G
End 
Select 
End 
Sub 
Public 
Shared 
Sub !
ExecuteInitialization /
(/ 0
)0 1
LevelCodeClass 
. 

Initialize %
(% &
)& '
End 
Sub 
Public 
Shared 
Sub 
ExecuteLoadContent ,
(, -
content- 4
As5 7
ContentManager8 F
)F G
LevelCodeClass 
. 
LoadContent &
(& '
content' .
). /
End 
Sub 
Public 
Shared 
Sub 
ExecuteDraw %
(% &
sb& (
As) +
SpriteBatch, 7
)7 8
LevelCodeClass 
. 
Draw 
(  
sb  "
)" #
End 
Sub 
Public 
Shared 
Sub 
ExecuteUpdate '
(' (
gameTime( 0
As1 3
GameTime4 <
)< =
LevelCodeClass 
. 
Update !
(! "
gameTime" *
)* +
End 
Sub 
End   
Class   
End!! 
	Namespace!! �s
�C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\WorldHandling\LevelHandling\LevelSpecificCode\Levels\IntroCity.vb
	Namespace 	
LevelSpecificCode
 
	Namespace 
Levels 
Public 
Class 
	IntroCity 
Inherits		 %
LevelSpecificCodeTemplate		 .
Private 
TrainX 
As 
Integer %
=& '
$num( )
Private 
TrainVelocityX "
As# %
Single& ,
=- .
$num/ 3
Private 
Class 
Textures "
Public 
Shared 
Logo "
As# %
	Texture2D& /
Public 
Shared 
TrainLights )
As* ,
	Texture2D- 6
End 
Class 
Sub 
New 
( 
level 
As 
Level "
," #
props$ )
As* ,
List- 1
(1 2
Of2 4
WorldObject5 @
)@ A
)A B
MyBase 
. 
New 
( 
level  
,  !
props" '
)' (
End 
Sub 
Public 
	Overrides 
Sub  

Initialize! +
(+ ,
), -
Level 
. 
Camera 
. 
Scale "
=# $
New% (
Vector3) 0
(0 1
$num1 4
,4 5
$num6 9
,9 :
$num; <
)< =
End 
Sub 
Public 
	Overrides 
Sub  
LoadContent! ,
(, -
content- 4
As5 7
ContentManager8 F
)F G
Textures 
. 
Logo 
= 
TextureLoader  -
.- .
Load. 2
(2 3
$str3 P
)P Q
Textures 
. 
TrainLights $
=% &
TextureLoader' 4
.4 5
Load5 9
(9 :
$str: c
)c d
End 
Sub 
Dim!! 
Transparency!! 
As!! 
Single!!  &
=!!' (
-!!) *
$num!!* -
Dim"" 
TrainCountdown"" 
As"" !
Integer""" )
=""* +
$num"", 0
Dim## !
PassingTrainActivated## %
As##& (
Boolean##) 0
=##1 2
False##3 8
Dim%% 

lastscroll%% 
As%% 
Integer%% %
=%%& '
$num%%( )
Dim&& 
musicPlaying&& 
As&& 
Boolean&&  '
=&&( )
False&&* /
Dim'' 
textCounter'' 
As'' 
Integer'' &
=''' (
$num'') *
Public(( 
	Overrides(( 
Sub((  
Draw((! %
(((% &
sb((& (
As(() +
SpriteBatch((, 7
)((7 8
sb)) 
.)) 
Begin)) 
()) 
,)) 

BlendState)) %
.))% &
NonPremultiplied))& 6
,))6 7
,))7 8
,))8 9
,))9 :
,)): ;
ScreenHandler))< I
.))I J
SelectedScreen))J X
.))X Y
ToWorld))Y `
.))` a
SelectedLevel))a n
.))n o
Camera))o u
.))u v
	GetMatrix))v 
(	)) �
)
))� �
)
))� �
Misc++ 
.++ 
DrawRectangle++ "
(++" #
sb++# %
,++% &
New++' *
	Rectangle+++ 4
(++4 5
$num++5 6
,++6 7
-++8 9
$num++9 =
,++= >
$num++? C
,++C D
$num++E I
)++I J
,++J K
Color++L Q
.++Q R
Black++R W
)++W X
sb-- 
.-- 
End-- 
(-- 
)-- 
sb// 
.// 
Begin// 
(// 
,// 

BlendState// %
.//% &
NonPremultiplied//& 6
,//6 7
,//7 8
,//8 9
,//9 :
,//: ;
)//; <
If11 
Transparency11 
<11  !
$num11" #
Then11$ (
Transparency22  
+=22! #
$num22$ )
Else33 !
PassingTrainActivated44 )
=44* +
True44, 0
End55 
If55 
If77 !
PassingTrainActivated77 (
Then77) -
If88 
TrainCountdown88 %
>88& '
-88( )
$num88) -
Then88. 2
TrainCountdown99 &
-=99' )
$num99* ,
End:: 
If:: 
End;; 
If;; 
If== 
TrainCountdown== !
<==" #
$num==$ (
Then==) -
If>> 
Transparency>> #
>>>$ %
$num>>& '
Then>>( ,
Transparency?? $
-=??% '
$num??( ,
Else@@ 
IfAA 
NotAA 
musicPlayingAA +
ThenAA, 0
musicPlayingBB (
=BB) *
TrueBB+ /
MediaCC !
.CC! "
MediaPlayerCC" -
.CC- .
VolumeCC. 4
=CC5 6
$numCC7 :
MediaDD !
.DD! "
MediaPlayerDD" -
.DD- .
PlayDD. 2
(DD2 3
SoundsDD3 9
.DD9 :
MusicDD: ?
.DD? @
SweetYouDD@ H
)DDH I
EndEE 
IfEE 
EndFF 
IfFF 
EndGG 
IfGG 
IfJJ 
textCounterJJ 
>JJ  
$numJJ! &
AndAlsoJJ' .
textCounterJJ/ :
<JJ; <
$numJJ= B
ThenJJC G
DrawTextFlickerKK #
(KK# $
sbKK$ &
,KK& '
$strKK( <
)KK< =
EndLL 
IfLL 
sbOO 
.OO 
DrawOO 
(OO 
TexturesOO  
.OO  !
TrainLightsOO! ,
,OO, -
NewOO. 1
Vector2OO2 9
(OO9 :
CSngOO: >
(OO> ?
graphicsOO? G
.OOG H$
PreferredBackBufferWidthOOH `
/OOa b
$numOOc d
)OOd e
+OOf g
TrainCountdownOOh v
,OOv w
CSngOOx |
(OO| }
graphics	OO} �
.
OO� �'
PreferredBackBufferHeight
OO� �
/
OO� �
$num
OO� �
)
OO� �
)
OO� �
,
OO� �
NothingPP 
,PP  
ColorPP! &
.PP& '
WhitePP' ,
,PP, -
NothingPP. 5
,PP5 6
NewPP7 :
Vector2PP; B
(PPB C
CSngPPC G
(PPG H
TexturesPPH P
.PPP Q
TrainLightsPPQ \
.PP\ ]
WidthPP] b
/PPc d
$numPPe f
)PPf g
,PPg h
CSngPPi m
(PPm n
TexturesPPn v
.PPv w
TrainLights	PPw �
.
PP� �
Height
PP� �
/
PP� �
$num
PP� �
)
PP� �
)
PP� �
,
PP� �
$num
PP� �
,
PP� �
Nothing
PP� �
,
PP� �
Nothing
PP� �
)
PP� �
sbRR 
.RR 
EndRR 
(RR 
)RR 
EndSS 
SubSS 
DimUU 
CounterUU 
AsUU 
IntegerUU "
=UU# $
-UU% &
$numUU& *
PublicVV 
	OverridesVV 
SubVV  
UpdateVV! '
(VV' (
gameTimeVV( 0
AsVV1 3
GameTimeVV4 <
)VV< =
DimWW 
selectedLevelWW !
=WW" #
ScreenHandlerWW$ 1
.WW1 2
SelectedScreenWW2 @
.WW@ A
ToWorldWWA H
.WWH I
SelectedLevelWWI V
IfYY 
PlayerYY 
IsYY 
NothingYY $
ThenYY% )
PlayerZZ 
=ZZ 
ScreenHandlerZZ *
.ZZ* +
SelectedScreenZZ+ 9
.ZZ9 :
ToWorldZZ: A
.ZZA B
PlayerZZB H
End[[ 
If[[ 
Counter]] 
+=]] 
gameTime]] #
.]]# $
ElapsedGameTime]]$ 3
.]]3 4
Milliseconds]]4 @
textCounter__ 
+=__ 
gameTime__ '
.__' (
ElapsedGameTime__( 7
.__7 8
Milliseconds__8 D
Dimaa 
Trainaa 
=aa 
Propsaa !
.aa! "
Findaa" &
(aa& '
Functionaa' /
(aa/ 0
xaa0 1
)aa1 2
xaa3 4
.aa4 5
Nameaa5 9
=aa: ;
$straa< D
)aaD E
Ifcc 
Traincc 
.cc 
Positioncc !
=cc" #
Newcc$ '
Vector2cc( /
(cc/ 0
$numcc0 1
,cc1 2
$numcc3 4
)cc4 5
Thencc6 :
Traindd 
.dd 
Positiondd "
.dd" #
Xdd# $
=dd% &
Traindd' ,
.dd, -
rectdd- 1
.dd1 2
Xdd2 3
*dd4 5
$numdd6 8
Trainee 
.ee 
Positionee "
.ee" #
Yee# $
=ee% &
Trainee' ,
.ee, -
rectee- 1
.ee1 2
Yee2 3
*ee4 5
$numee6 8
Playergg 
.gg 
Visiblegg "
=gg# $
Falsegg% *
Playerhh 
.hh 

HasGravityhh %
=hh& '
Falsehh( -
Endii 
Ifii 
Ifmm 
Countermm 
>mm 
$nummm 
Thenmm  $
Counternn 
=nn 
$numnn 
Ifoo 
Trainoo 
.oo 
Positionoo %
.oo% &
Xoo& '
<oo( )
$numoo* .
Thenoo/ 3
Trainpp 
.pp 
Positionpp &
.pp& '
Xpp' (
+=pp) +
TrainVelocityXpp, :
Playerqq 
.qq 
Positionqq '
=qq( )
Trainqq* /
.qq/ 0
Positionqq0 8
+qq9 :
Newqq; >
Vector2qq? F
(qqF G
$numqqG J
,qqJ K
$numqqL M
)qqM N
Elserr 
Ifss 
TrainVelocityXss )
>ss* +
$numss, -
Thenss. 2
Traintt !
.tt! "
Positiontt" *
.tt* +
Xtt+ ,
+=tt- /
TrainVelocityXtt0 >
TrainVelocityXuu *
-=uu+ -
$numuu. 3
Playervv "
.vv" #
Positionvv# +
=vv, -
Trainvv. 3
.vv3 4
Positionvv4 <
+vv= >
Newvv? B
Vector2vvC J
(vvJ K
$numvvK N
,vvN O
$numvvP S
)vvS T
Elseww 
Playerxx "
.xx" #

HasGravityxx# -
=xx. /
Truexx0 4
Playeryy "
.yy" #
Visibleyy# *
=yy+ ,
Trueyy- 1
Endzz 
Ifzz 
End{{ 
If{{ 
End|| 
If|| 
Level 
. 
Camera 
. 
FocusOnPosition ,
(, -
Train- 2
.2 3
Position3 ;
+< =
New> A
Vector2B I
(I J
$numJ M
,M N
$numO P
)P Q
)Q R
End
�� 
Sub
�� 
Dim
�� 
displacement
�� 
As
�� 
New
��  #
Vector2
��$ +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
)
��0 1
Private
�� 
Sub
�� 
DrawTextFlicker
�� '
(
��' (
sb
��( *
As
��+ -
SpriteBatch
��. 9
,
��9 :
text
��; ?
As
��@ B
String
��C I
)
��I J
If
�� 
displacement
�� 
=
��  !
New
��" %
Vector2
��& -
(
��- .
$num
��. /
,
��/ 0
$num
��1 2
)
��2 3
Then
��4 8
If
�� 
Random
�� 
.
�� 
Next
�� "
(
��" #
$num
��# $
,
��$ %
$num
��& (
)
��( )
=
��* +
$num
��, -
Then
��. 2
displacement
�� $
=
��% &
New
��' *
Vector2
��+ 2
(
��2 3
Random
��3 9
.
��9 :
Next
��: >
(
��> ?
-
��? @
$num
��@ B
,
��B C
$num
��D F
)
��F G
,
��G H
Random
��I O
.
��O P
Next
��P T
(
��T U
-
��U V
$num
��V X
,
��X Y
$num
��Z \
)
��\ ]
)
��] ^
End
�� 
If
�� 
Else
�� 
If
�� 
Random
�� 
.
�� 
Next
�� "
(
��" #
$num
��# $
,
��$ %
$num
��& '
)
��' (
=
��) *
$num
��+ ,
Then
��- 1
displacement
�� $
=
��% &
New
��' *
Vector2
��+ 2
(
��2 3
$num
��3 4
,
��4 5
$num
��6 7
)
��7 8
End
�� 
If
�� 
End
�� 
If
�� 
sb
�� 
.
�� 

DrawString
�� 
(
�� 
Fonts
�� #
.
��# $
ChakraPetch
��$ /
.
��/ 0

ExtraLarge
��0 :
,
��: ;
text
�� "
,
��" #
New
�� !
Vector2
��" )
(
��) *
CSng
��* .
(
��. /
graphics
��/ 7
.
��7 8&
PreferredBackBufferWidth
��8 P
/
��Q R
$num
��S T
-
��U V
Fonts
��W \
.
��\ ]
ChakraPetch
��] h
.
��h i

ExtraLarge
��i s
.
��s t
MeasureString��t �
(��� �
text��� �
)��� �
.��� �
X��� �
/��� �
$num��� �
)��� �
,��� �
$num��� �
)��� �
+��� �
displacement��� �
,��� �
Color
�� #
.
��# $
Black
��$ )
)
��) *
End
�� 
Sub
�� 
End
�� 
Class
�� 
End
�� 
	Namespace
�� 
End�� 
	Namespace
�� �
�C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\WorldHandling\LevelHandling\LevelSpecificCode\Levels\LevelSpecificCodeTemplate.vb
Public 
MustInherit 
Class %
LevelSpecificCodeTemplate 2
Public

 

MustOverride

 
Sub

 

Initialize

 &
(

& '
)

' (
Public 

MustOverride 
Sub 
LoadContent '
(' (
content( /
As0 2
ContentManager3 A
)A B
Public 

MustOverride 
Sub 
Draw  
(  !
sb! #
As$ &
SpriteBatch' 2
)2 3
Public 

MustOverride 
Sub 
Update "
(" #
gameTime# +
As, .
GameTime/ 7
)7 8
Friend 

Player 
As 
Player 
Friend 

Props 
As 
List 
( 
Of 
WorldObject '
)' (
Friend 

ReadOnly 
Level 
As 
Level "
Sub 
New 
( 
level 
As 
Level 
, 
props !
As" $
List% )
() *
Of* ,
WorldObject- 8
)8 9
)9 :
Me   

.  
 
Props   
=   
props   
Me!! 

.!!
 
Level!! 
=!! 
level!! 
End"" 
Sub"" 
End## 
Class## 	�
�C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\WorldHandling\LevelHandling\Objects\TechnicalObjects\InfoBoxDisplay.vb
Public 
Class 
InfoBoxDisplay 
Inherits 
TechnicalObject 
Public 

Text 
As 
String 
= 
$str 
Sub 
New 
( 
) 
Name 
= 
$str 
End 
Sub 
Public

 

	Overrides

 
Sub

 
Interaction

 $
(

$ %
)

% &
MyBase 
. 
Interaction 
( 
) 
InfoBox 
. 
Show 
( 
Text 
) 
End 
Sub 
End 
Class 	�
�C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\WorldHandling\LevelHandling\Objects\TechnicalObjects\LoadingZone.vb
Public 
Class 
LoadingZone 
Inherits 
TechnicalObject 
Public 

TargetLevelName 
As 
String $
=% &
$str' )
Public		 

Shared		 
NotificationTexture		 %
As		& (
	Texture2D		) 2
Sub 
New 
( 
) 
Name 
= 
$str 
End 
Sub 
Public 

	Overrides 
Sub 
Update 
(  
gameTime  (
As) +
GameTime, 4
)4 5
MyBase 
. 
Update 
( 
gameTime 
) 
End 
Sub 
Public 

	Overrides 
Sub 
Draw 
( 
sb  
As! #
SpriteBatch$ /
)/ 0
If 

IsPlayerInRange 
Then 
sb 
. 
Draw 
( 
NotificationTexture '
,' (
New) ,
	Rectangle- 6
(6 7
GetTrueRect7 B
.B C
LocationC K
-L M
NewN Q
PointR W
(W X
$numX Y
,Y Z
$num[ ]
)] ^
,^ _
New` c
Pointd i
(i j
$numj m
,m n
$numo q
)q r
)r s
,s t
Coloru z
.z {
White	{ �
)
� �
End 
If 
End 
Sub 
Public 

	Overrides 
Sub 
Interaction $
($ %
)% &
End 
Sub 
End 
Class 	�
�C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\WorldHandling\LevelHandling\Objects\TechnicalObjects\ParticleSpawner.vb
Public 
Class 
ParticleSpawner 
Inherits 
TechnicalObject 
Public 

ps 
As 
New 
ParticleSystem #
Public 

InnerPosition 
As 
Vector2 #
Sub		 
New		 
(		 
)		 
Name

 
=

 
$str

 
&

 
	vbNewLine

 %
&

& '
$str

( 1
Throw 
New #
NotImplementedException )
End 
Sub 
Public 

	Overrides 
Sub 
Draw 
( 
sb  
As! #
SpriteBatch$ /
)/ 0
Throw 
New #
NotImplementedException )
End 
Sub 
End 
Class 	�
�C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\WorldHandling\LevelHandling\Objects\TechnicalObjects\PlayerSpawn.vb
Public 
Class 
PlayerSpawn 
Inherits 
TechnicalObject 
Sub 
New 
( 
) 
Name 
= 
$str 
End 
Sub 
End 
Class 	�
�C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\WorldHandling\LevelHandling\Objects\TechnicalObjects\PlayerTrigger.vb
Public 
Class 
PlayerTrigger 
Inherits 
TechnicalObject 
Public 

ActivationType 
As 
ActivationTypes ,
Public 

ActivationDelay 
As 
Integer %
=& '
$num( )
Public		 

TargetID		 
As		 
String		 
=		 
$str		  "
Public 

Enum 
ActivationTypes 
Once 
OnEnter 
Repeat 
End 
Enum 
Sub 
New 
( 
) 
Name 
= 
$str 
& 
	vbNewLine #
&$ %
$str& /
Throw 
New #
NotImplementedException )
End 
Sub 
End 
Class 	�
�C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\WorldHandling\LevelHandling\Objects\TechnicalObjects\Spawner.vb
Public 
Class 
Spawner 
Inherits 
TechnicalObject 
Public 

ID 
As 
String 
Public 

EnemySpawned 
As 
Boolean "
=# $
False% *
Sub 
New 
( 
) 
Name 
= 
$str 
End 
Sub 
Public 

	Overrides 
Sub 
Update 
(  
gameTime  (
As) +
GameTime, 4
)4 5
MyBase 
. 
Update 
( 
gameTime 
) 
If 

Not 
EnemySpawned 
Then  

SpawnEnemy 
( 
) 
EnemySpawned 
= 
True 
End 
If 
End 
Sub 
Public 

Sub 

SpawnEnemy 
( 
) 
Dim 
_e 
As 
New 
Enemy 
( 
$num 
) 
With  $
{% &
.& '
Position' /
=0 1
Me2 4
.4 5
GetTrueRect5 @
.@ A
LocationA I
.I J
	ToVector2J S
,S T
.U V

AnimationsV `
=a b
AnimationSetsc p
.p q
Playerq w
}w x
_e 

.
  
SetSelectedAnimation 
(  
$str  &
)& '
ScreenHandler 
. 
SelectedScreen $
.$ %
ToWorld% ,
., -
SelectedLevel- :
.: ;
NPCs; ?
.? @
Add@ C
(C D
_eD F
)F G
End 
Sub 
End 
Class 	�
�C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\WorldHandling\LevelHandling\Objects\TechnicalObjects\TechnicalObject.vb
Public 
Class 
TechnicalObject 
Inherits 
WorldObject 
Public 

	Activated 
As 
Boolean 
=  !
True" &
Public 

	Overrides 
Sub 
Draw 
( 
sb  
As! #
SpriteBatch$ /
)/ 0
MyBase 
. 
Draw 
( 
sb 
) 
End		 
Sub		 
End

 
Class

 	�
nC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ResourceHandling\SoundSystem\Sounds.vb
Public 
Class 
Sounds 
Public 

Class 
World 
End		 
Class		 
Public 

Class 

Characters 
Public 
Class 
Player 
End 
Class 
End 
Class 
Public 

Class 
Weapons 
Public 
Class 
AR 
End 
Class 
Public 
Class 
Pistol 
Public 
Shared 
Reload  
As! #
SoundEffect$ /
Public 
Shared 
Shoot 
As  "
SoundEffect# .
End 
Class 
End 
Class 
Public 

Class 
Music 
Public 
Shared 
ReadOnly 
Property '
SweetYou( 0
As1 3
Song4 8
Get 
Return 
Song 
. 
FromUri #
(# $
$str$ /
,/ 0
New1 4
Uri5 8
(8 9
Path9 =
.= >
Combine> E
(E F
WindowsF M
.M N
FormsN S
.S T
ApplicationT _
._ `
StartupPath` k
,k l
$str	m �
)
� �
)
� �
)
� �
End   
Get   
End!! 
Property!! 
End"" 
Class"" 
Public$$ 

Shared$$ 
Sub$$ 

LoadSounds$$  
($$  !
Content$$! (
As$$) +
ContentManager$$, :
)$$: ;
Weapons%% 
.%% 
Pistol%% 
.%% 
Reload%% 
=%% 
Content%%  '
.%%' (
Load%%( ,
(%%, -
Of%%- /
SoundEffect%%0 ;
)%%; <
(%%< =
$str%%= b
)%%b c
Weapons&& 
.&& 
Pistol&& 
.&& 
Shoot&& 
=&& 
Content&& &
.&&& '
Load&&' +
(&&+ ,
Of&&, .
SoundEffect&&/ :
)&&: ;
(&&; <
$str&&< `
)&&` a
End'' 
Sub'' 
End(( 
Class(( 	�&
�C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Graphics\SpriteHandling\AnimatedSprite\AnimatedSprite.vb
Public 
Class 
AnimatedSprite 
Inherits 
Sprite 
Public 


Animations 
As 
AnimationSet %
	Protected		 
srcRect		 
As		 
New		 
	Rectangle		 &
(		& '
$num		' (
,		( )
$num		* +
,		+ ,
$num		- .
,		. /
$num		0 1
)		1 2
	Protected

 
SelectedAnimation

 
As

  "
	Animation

# ,
	Protected 

FrameWidth 
As 
Integer #
Private 
ElapsedTime 
As 
Integer "
=# $
$num% &
Sub 
New 
( 
	_frmWidth 
As 
Integer  
)  !

FrameWidth 
= 
	_frmWidth 
End 
Sub 
Public 

	Overrides 
Sub 
Draw 
( 
sb  
As! #
SpriteBatch$ /
)/ 0
If 

SelectedAnimation 
IsNot "
Nothing# *
Then+ /
sb 
. 
Draw 
( 
texture 
:= 
SelectedAnimation .
.. /
Texture/ 6
,6 7
position 
:= 
Position &
,& '
sourceRectangle #
:=# %
srcRect% ,
,, -
scale 
:= 
New 
Vector2 &
(& '
Scale' ,
,, -
Scale. 3
)3 4
)4 5
End 
If 
End 
Sub 
Public 

	Overrides 
Sub 
Update 
(  
gameTime  (
As) +
GameTime, 4
)4 5
srcRect 
. 
Width 
= 

FrameWidth "
srcRect 
. 
Height 
= 
SelectedAnimation *
.* +
Texture+ 2
.2 3
Height3 9
srcRect 
. 
Y 
= 
$num 
srcRect 
. 
X 
= 
CInt 
( 
Math 
. 
Floor #
(# $
ElapsedTime$ /
/0 1
SelectedAnimation2 C
.C D
FrameDurationD Q
)Q R
)R S
*T U

FrameWidthV `
ElapsedTime!! 
+=!! 
CInt!! 
(!! 
gameTime!! $
.!!$ %
ElapsedGameTime!!% 4
.!!4 5
TotalMilliseconds!!5 F
)!!F G
If$$ 

ElapsedTime$$ 
>=$$ 
SelectedAnimation$$ +
.$$+ ,
FrameDuration$$, 9
*$$: ;
SelectedAnimation$$< M
.$$M N
Texture$$N U
.$$U V
Width$$V [
/$$\ ]

FrameWidth$$^ h
Then$$i m
If%% 
SelectedAnimation%%  
.%%  !
IterationCount%%! /
>%%0 1
$num%%2 3
Then%%4 8
SelectedAnimation&& !
.&&! "
IterationCount&&" 0
-=&&1 3
$num&&4 5
End'' 
If'' 
If(( 
SelectedAnimation((  
.((  !
IterationCount((! /
<>((0 2
$num((3 4
Then((5 9
ElapsedTime)) 
=)) 
$num)) 
End** 
If** 
End,, 
If,, 
End-- 
Sub-- 
Public// 

Sub//  
SetSelectedAnimation// #
(//# $
	_animName//$ -
As//. 0
String//1 7
)//7 8
For00 
Each00 
_anim00 
In00 

Animations00 $
.00$ %

Animations00% /
If11 
_anim11 
.11 
Name11 
=11 
	_animName11 %
Then11& *
SelectedAnimation22 !
=22" #
_anim22$ )
End33 
If33 
Next44 
End55 
Sub55 
Public77 

Function77 
getTextureSize77 "
(77" #
)77# $
As77% '
Vector277( /
Return88 
New88 
Vector288 
(88 

FrameWidth88 %
,88% &

Animations88' 1
.881 2

Animations882 <
(88< =
$num88= >
)88> ?
.88? @
Texture88@ G
.88G H
Height88H N
)88N O
End99 
Function99 
End:: 
Class:: 	�
{C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Graphics\SpriteHandling\AnimatedSprite\Animation.vb
Public 
Class 
	Animation 
Public 

Name 
As 
String 
Public 

FrameDuration 
As 
Integer #
Public 

Texture 
As 
	Texture2D 
Public 

TexturePath 
As 
String  
Public		 

IterationCount		 
As		 
Integer		 $
=		% &
-		' (
$num		( )
Sub 
New 
( 
_name 
As 
String 
, 
_texPath %
As& (
String) /
,/ 0
	_frameDur1 :
As; =
Integer> E
)E F
Name 
= 
_name 
TexturePath 
= 
_texPath 
FrameDuration 
= 
	_frameDur !
End 
Sub 
Public 

Sub 
LoadContent 
( 
_content #
As$ &
ContentManager' 5
)5 6
Texture 
= 
TextureLoader 
.  
Load  $
($ %
TexturePath% 0
)0 1
TexturePath 
= 
Nothing 
End 
Sub 
End 
Class 	�
~C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Graphics\SpriteHandling\AnimatedSprite\AnimationSet.vb
Public 
Class 
AnimationSet 
Public 

_Animations 
As 
New 
List "
(" #
Of# %
	Animation& /
)/ 0
Sub 
New 
( 
) 
End 
Sub 
Sub

 
New

 
(

 
_anims

 
As

 
	Animation

 
(

  
)

  !
)

! "

Animations 
. 
AddRange 
( 
_anims "
)" #
End 
Sub 
Public 

Property 

Animations 
As !
List" &
(& '
Of' )
	Animation* 3
)3 4
Get 
Return 
_Animations 
End 
Get 
Set 
( 
value 
As 
List 
( 
Of 
	Animation &
)& '
)' (
_Animations 
= 
value 
End 
Set 
End 
Property 
Public 

Sub 
AddAnimation 
( 
anim  
As! #
	Animation$ -
)- .

Animations 
. 
Add 
( 
anim 
) 
End 
Sub 
Public 

Sub 
LoadContent 
( 
Content "
As# %
ContentManager& 4
)4 5
For 
Each 
_anim 
In 

Animations $
_anim 
. 
LoadContent 
( 
Content %
)% &
Next 
End 
Sub 
End   
Class   	�
C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Graphics\SpriteHandling\AnimatedSprite\AnimationSets.vb
Public 
Class 
AnimationSets 
Public 

Shared 
Player 
As 
New 
AnimationSet  ,
(, -
{- .
New. 1
	Animation2 ;
(; <
$str< B
,B C
$strD d
,d e
$numf i
)i j
}j k
)k l
Public 

Shared 
BasicSoldier 
As !
New" %
AnimationSet& 2
Public 

Shared 
Sub 
LoadContent !
(! "
Content" )
As* ,
ContentManager- ;
); <
Player 
. 
LoadContent 
( 
Content "
)" #
End		 
Sub		 
End

 
Class

 	�(
iC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\Graphics\SpriteHandling\Sprite.vb
Public 
Class 
Sprite 
Public 

Name 
As 
String 
Public 

Texture 
As 
	Texture2D 
Public 

Position 
As 
Vector2 
Public 

Scale 
As 
Single 
= 
$num !
Public 

Hitbox 
As 
Polygon 
Sub 
New 
( 
) 
End 
Sub 
Public   

Overridable   
Sub   
Update   !
(  ! "
gameTime  " *
As  + -
GameTime  . 6
)  6 7
End"" 
Sub"" 
Public$$ 

Overridable$$ 
Sub$$ 
Draw$$ 
($$  
sb$$  "
As$$# %
SpriteBatch$$& 1
)$$1 2
If%% 

Texture%% 
IsNot%% 
Nothing%%  
Then%%! %
sb&& 
.&& 
Draw&& 
(&& 
texture&& 
:=&& 
Texture&& $
,&&$ %
position'' 
:='' 
Position'' &
,''& '
scale(( 
:=(( 
New(( 
Vector2(( &
(((& '
Scale((' ,
,((, -
Scale((. 3
)((3 4
)((4 5
End)) 
If)) 
End** 
Sub** 
Public,, 

Overridable,, 
Function,, 
GetScreenRect,,  -
(,,- .
),,. /
As,,0 2
	Rectangle,,3 <
Dim-- 
selectedLevel-- 
=-- 
ScreenHandler-- )
.--) *
SelectedScreen--* 8
.--8 9
ToWorld--9 @
.--@ A
SelectedLevel--A N
If// 

Texture// 
IsNot// 
Nothing//  
Then//! %
Return00 
New00 
	Rectangle00  
(00  !
CInt00! %
(00% &
Position00& .
.00. /
X00/ 0
-001 2
selectedLevel003 @
.00@ A
Camera00A G
.00G H
Translation00H S
.00S T
X00T U
)00U V
,00V W
CInt00X \
(00\ ]
Position00] e
.00e f
Y00f g
-00h i
selectedLevel00j w
.00w x
Camera00x ~
.00~ 
Translation	00 �
.
00� �
Y
00� �
)
00� �
,
00� �
CInt
00� �
(
00� �
Texture
00� �
.
00� �
Width
00� �
*
00� �
Scale
00� �
)
00� �
,
00� �
CInt
00� �
(
00� �
Texture
00� �
.
00� �
Height
00� �
*
00� �
Scale
00� �
)
00� �
)
00� �
Else11 
Return22 
New22 
	Rectangle22  
(22  !
CInt22! %
(22% &
Position22& .
.22. /
X22/ 0
-221 2
selectedLevel223 @
.22@ A
Camera22A G
.22G H
Translation22H S
.22S T
X22T U
)22U V
,22V W
CInt22X \
(22\ ]
Position22] e
.22e f
Y22f g
-22h i
selectedLevel22j w
.22w x
Camera22x ~
.22~ 
Translation	22 �
.
22� �
Y
22� �
)
22� �
,
22� �
$num
22� �
,
22� �
$num
22� �
)
22� �
End33 
If33 
End44 
Function44 
Public66 

Overridable66 
Function66 
GetTrueRect66  +
(66+ ,
)66, -
As66. 0
	Rectangle661 :
If77 

Texture77 
IsNot77 
Nothing77  
Then77! %
Return88 
New88 
	Rectangle88  
(88  !
CInt88! %
(88% &
Position88& .
.88. /
X88/ 0
)880 1
,881 2
CInt883 7
(887 8
Position888 @
.88@ A
Y88A B
)88B C
,88C D
CInt88E I
(88I J
Texture88J Q
.88Q R
Width88R W
*88X Y
Scale88Z _
)88_ `
,88` a
CInt88b f
(88f g
Texture88g n
.88n o
Height88o u
*88v w
Scale88x }
)88} ~
)88~ 
Else99 
Return:: 
New:: 
	Rectangle::  
(::  !
CInt::! %
(::% &
Position::& .
.::. /
X::/ 0
)::0 1
,::1 2
CInt::3 7
(::7 8
Position::8 @
.::@ A
Y::A B
)::B C
,::C D
$num::E F
,::F G
$num::H I
)::I J
End;; 
If;; 
End<< 
Function<< 
End== 
Class== 	��
{C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\WorldHandling\LevelHandling\Level.vb
Public

 
Class

 
Level

 
Public 

Name 
As 
String 
= 
$str 
Public 

Camera 
As 
New 
Camera 
Public 

Property 
PlacedObjects !
As" $
WorldObject% 0
(0 1
)1 2
Get 
Return 
_PlacedObjects !
End 
Get 
Set 
( 
value 
As 
WorldObject  
(  !
)! "
)" #
_PlacedObjects 
= 
value "
Array 
. 
Sort 
( 
_PlacedObjects %
,% &
Function' /
(/ 0
x0 1
,1 2
y3 4
)4 5
x6 7
.7 8
zIndex8 >
.> ?
	CompareTo? H
(H I
yI J
.J K
zIndexK Q
)Q R
)R S
	LevelMaxX 
= 
$num 
	LevelMaxY 
= 
$num 
For   
Each   
wObj   
In   
_PlacedObjects   +
If!! 
wObj!! 
.!! 
rect!! 
.!! 
X!! 
>!!  
	LevelMaxX!!! *
Then!!+ /
	LevelMaxX"" 
="" 
wObj""  $
.""$ %
rect""% )
."") *
X""* +
End## 
If## 
If%% 
wObj%% 
.%% 
rect%% 
.%% 
Y%% 
>%%  
	LevelMaxY%%! *
Then%%+ /
	LevelMaxY&& 
=&& 
wObj&&  $
.&&$ %
rect&&% )
.&&) *
Y&&* +
End'' 
If'' 
Next(( 
End)) 
Set)) 
End** 
Property** 
Private++ 
_PlacedObjects++ 
(++ 
)++ 
As++ 
WorldObject++  +
Private-- 
	LevelMaxX-- 
As-- 
Integer--  
Private.. 
	LevelMaxY.. 
As.. 
Integer..  
Public33 

Props33 
As33 
New33 
List33 
(33 
Of33 
WorldObject33  +
)33+ ,
Public88 

LightPolygons88 
As88 
New88 
List88  $
(88$ %
Of88% '
Polygon88( /
)88/ 0
Public== 

NPCs== 
As== 
New== 
List== 
(== 
Of== 
NPC== "
)==" #
PublicBB 

	TimeOfDayBB 
AsBB 
SingleBB 
=BB  
$numBB! "
PublicDD 

BackgroundImageDD 
AsDD 
	Texture2DDD '
PrivateFF 
CloudsFF 
(FF 
$numFF 
)FF 
AsFF 
SpriteFF  
PrivateGG 
	SkyColorsGG 
(GG 
$numGG 
)GG 
AsGG 
ColorGG "
PrivateHH 
BackgroundGradientHH 
AsHH !
	Texture2DHH" +
PrivateJJ 
ShadowOverlayJJ 
AsJJ 
RenderTarget2DJJ +
SubLL 
NewLL 
(LL 
_placedObjsLL 
AsLL 
ListLL 
(LL  
OfLL  "
WorldObjectLL# .
)LL. /
)LL/ 0
PlacedObjectsMM 
=MM 
_placedObjsMM #
.MM# $
ToArrayMM$ +
EndNN 
SubNN 
PublicPP 

SubPP 
LoadContentPP 
(PP 
ContentPP "
AsPP# %
ContentManagerPP& 4
)PP4 5
LevelSpecificCodeQQ 
.QQ 
LevelSpecificCodeQQ +
.QQ+ ,
SetCurrentLevelQQ, ;
(QQ; <
MeQQ< >
,QQ> ?
PropsQQ@ E
)QQE F
LevelSpecificCodeSS 
.SS 
LevelSpecificCodeSS +
.SS+ ,!
ExecuteInitializationSS, A
(SSA B
)SSB C
DimUU 
fUU 
AsUU 
NewUU 
FriendlyUU 
(UU 
$numUU  
)UU  !
WithUU" &
{UU' (
.UU( )
PositionUU) 1
=UU2 3
NewUU4 7
Vector2UU8 ?
(UU? @
$numUU@ C
,UUC D
$numUUE G
)UUG H
,UUH I
.UUJ K

AnimationsUUK U
=UUV W
AnimationSetsUUX e
.UUe f
PlayerUUf l
}UUl m
fWW 	
.WW	 

DialogueWW
 
=WW 
NewWW 
DialogueWW !
fYY 	
.YY	 

DialogueYY
 
.YY 
SegmentsYY 
=YY 
{YY 
NewYY "
DialogueSegmentYY# 2
WithYY3 7
{YY8 9
.YY9 :

FaceSpriteYY: D
=YYE F
TextureLoaderYYG T
.YYT U
LoadYYU Y
(YYY Z
$str	YYZ �
)
YY� �
,
YY� �
.
YY� �
Text
YY� �
=
YY� �
$str
YY� �
}
YY� �
,
YY� �
New
YY� �
DialogueSegment
YY� �
With
YY� �
{
YY� �
.
YY� �
Text
YY� �
=
YY� �
$str
YY� �
&
YY� �
	vbNewLine
YY� �
&
YY� �
$str
YY� �
,
YY� �
.
YY� �

FaceSprite
YY� �
=
YY� �
TextureLoader
YY� �
.
YY� �
Load
YY� �
(
YY� �
$str
YY� �
)
YY� �
}
YY� �
}
YY� �
fZZ 	
.ZZ	 
 
SetSelectedAnimationZZ
 
(ZZ 
$strZZ %
)ZZ% &
NPCs[[ 
.[[ 
Add[[ 
([[ 
f[[ 
)[[ 
Textures]] 
.]] 
SkyGradient]] 
.]] 
GetData]] $
(]]$ %
	SkyColors]]% .
)]]. /
For__ 
i__ 
As__ 
Integer__ 
=__ 
$num__ 
To__ 
Clouds__  &
.__& '
Length__' -
-__. /
$num__0 1
Clouds`` 
(`` 
i`` 
)`` 
=`` 
New`` 
Sprite`` "
(``" #
)``# $
With``% )
{``* +
.aa 
Textureaa 
=aa 
Texturesaa #
.aa# $
Cloudsaa$ *
(aa* +
Randomaa+ 1
.aa1 2
Nextaa2 6
(aa6 7
$numaa7 8
,aa8 9
Texturesaa: B
.aaB C
CloudsaaC I
.aaI J
LengthaaJ P
)aaP Q
)aaQ R
,aaR S
.bb 
Scalebb 
=bb 
$numbb 
}bb 
Cloudscc 
(cc 
icc 
)cc 
.cc 
Positioncc 
=cc  
Newcc! $
Vector2cc% ,
(cc, -
Randomcc- 3
.cc3 4
Nextcc4 8
(cc8 9
CIntcc9 =
(cc= >
-cc> ?
Cloudscc? E
(ccE F
iccF G
)ccG H
.ccH I
TextureccI P
.ccP Q
WidthccQ V
*ccW X
CloudsccY _
(cc_ `
icc` a
)cca b
.ccb c
Scaleccc h
*cci j
$numcck l
)ccl m
,ccm n
graphicscco w
.ccw x%
PreferredBackBufferWidth	ccx �
)
cc� �
,
cc� �
Random
cc� �
.
cc� �
Next
cc� �
(
cc� �
$num
cc� �
,
cc� �
$num
cc� �
)
cc� �
)
cc� �
Nextdd 
Forhh 
Eachhh 
objhh 
Inhh 
PlacedObjectshh %
Ifii 
objii 
IsNotii 
Nothingii  
Thenii! %
Ifkk 
objkk 
.kk 
IsPropkk 
Thenkk "
Propsll 
.ll 
Addll 
(ll 
objll !
)ll! "
Endmm 
Ifmm 
Endnn 
Ifnn 
Nextoo 
LevelSpecificCodeqq 
.qq 
LevelSpecificCodeqq +
.qq+ ,
ExecuteLoadContentqq, >
(qq> ?
Contentqq? F
)qqF G
Endrr 
Subrr 
Publictt 

Subtt 
Drawtt 
(tt 
ByReftt 
sbtt 
Astt 
SpriteBatchtt  +
,tt+ ,
ByReftt- 2
playertt3 9
Astt: <
Playertt= C
)ttC D
Ifuu 

BackgroundImageuu 
IsNotuu  
Nothinguu! (
Thenuu) -
sbvv 
.vv 
Beginvv 
(vv 
,vv 

BlendStatevv !
.vv! "
NonPremultipliedvv" 2
,vv2 3
,vv3 4
,vv4 5
,vv5 6
,vv6 7
)vv7 8
sbww 
.ww 
Drawww 
(ww 
BackgroundImageww #
,ww# $
Newww% (
	Rectangleww) 2
(ww2 3
$numww3 4
,ww4 5
$numww6 7
,ww7 8
graphicsww9 A
.wwA B$
PreferredBackBufferWidthwwB Z
,wwZ [
graphicsww\ d
.wwd e%
PreferredBackBufferHeightwwe ~
)ww~ 
,	ww �
Color
ww� �
.
ww� �
White
ww� �
)
ww� �
sbxx 
.xx 
Endxx 
(xx 
)xx 
Endyy 
Ifyy 
DrawSky|| 
(|| 
sb|| 
)|| 
Dim
�� "
firstForegroundIndex
��  
As
��! #
Integer
��$ +
=
��, -
Array
��. 3
.
��3 4
	FindIndex
��4 =
(
��= >
PlacedObjects
��> K
,
��K L
Function
��M U
(
��U V
x
��V W
)
��W X
x
��Y Z
.
��Z [
zIndex
��[ a
=
��b c
$num
��d f
)
��f g
For
�� 
i
�� 
As
�� 
Integer
�� 
=
�� 
$num
�� 
To
�� 
If
��  "
(
��" #"
firstForegroundIndex
��# 7
<>
��8 :
-
��; <
$num
��< =
,
��= >"
firstForegroundIndex
��? S
-
��T U
$num
��V W
,
��W X
PlacedObjects
��Y f
.
��f g
Length
��g m
-
��n o
$num
��p q
)
��q r
Dim
�� 
obj
�� 
=
�� 
PlacedObjects
�� #
(
��# $
i
��$ %
)
��% &
If
�� 
obj
�� 
.
��  
ParallaxMultiplier
�� %
<>
��& (
$num
��) -
Then
��. 2
sb
�� 
.
�� 
Begin
�� 
(
�� 
Nothing
��  
,
��  !

BlendState
��" ,
.
��, -
NonPremultiplied
��- =
,
��= >
SamplerState
��? K
.
��K L
LinearClamp
��L W
,
��W X
Nothing
��  
,
��  !
Nothing
��" )
,
��) *
Nothing
��+ 2
,
��2 3
Camera
��4 :
.
��: ;
	GetMatrix
��; D
(
��D E
New
��E H
Vector3
��I P
(
��P Q
obj
��Q T
.
��T U 
ParallaxMultiplier
��U g
)
��g h
)
��h i
)
��i j
Else
�� 
sb
�� 
.
�� 
Begin
�� 
(
�� 
Nothing
��  
,
��  !

BlendState
��" ,
.
��, -
NonPremultiplied
��- =
,
��= >
SamplerState
��? K
.
��K L
LinearClamp
��L W
,
��W X
Nothing
��Y `
,
��` a
Nothing
��b i
,
��i j
Nothing
��k r
,
��r s
Camera
��t z
.
��z {
	GetMatrix��{ �
(��� �
)��� �
)��� �
End
�� 
If
�� 
obj
�� 
.
�� 
Draw
�� 
(
�� 
sb
�� 
)
�� 
sb
�� 
.
�� 
End
�� 
(
�� 
)
�� 
Next
�� 
sb
�� 

.
��
 
Begin
�� 
(
�� 
Nothing
�� 
,
�� 

BlendState
�� $
.
��$ %
NonPremultiplied
��% 5
,
��5 6
SamplerState
��7 C
.
��C D
LinearClamp
��D O
,
��O P
Nothing
��Q X
,
��X Y
Nothing
��Z a
,
��a b
Nothing
��c j
,
��j k
Camera
��l r
.
��r s
	GetMatrix
��s |
(
��| }
)
��} ~
)
��~ 
player
�� 
.
�� 
Draw
�� 
(
�� 
sb
�� 
)
�� 
For
�� 
Each
�� 
NPC
�� 
In
�� 
NPCs
�� 
NPC
�� 
.
�� 
Draw
�� 
(
�� 
sb
�� 
)
�� 
Next
�� 
sb
�� 

.
��
 
End
�� 
(
�� 
)
�� 
If
�� 
"
firstForegroundIndex
�� 
<>
��  "
-
��# $
$num
��$ %
Then
��& *
For
�� 
i
�� 
As
�� 
Integer
�� 
=
�� "
firstForegroundIndex
�� 3
-
��4 5
$num
��6 7
To
��8 :
PlacedObjects
��; H
.
��H I
Length
��I O
-
��P Q
$num
��R S
MsgBox
�� 
(
�� 
i
�� 
)
�� 
Dim
�� 
obj
�� 
=
�� 
PlacedObjects
�� '
(
��' (
i
��( )
)
��) *
If
�� 
obj
�� 
.
��  
ParallaxMultiplier
�� )
<>
��* ,
$num
��- 1
Then
��2 6
sb
�� 
.
�� 
Begin
�� 
(
�� 
Nothing
�� $
,
��$ %

BlendState
��& 0
.
��0 1
NonPremultiplied
��1 A
,
��A B
SamplerState
��C O
.
��O P
LinearClamp
��P [
,
��[ \
Nothing
��  
,
��  !
Nothing
��" )
,
��) *
Nothing
��+ 2
,
��2 3
Matrix
�� 
.
��  
CreateTranslation
��  1
(
��1 2
Camera
��2 8
.
��8 9
Translation
��9 D
.
��D E
X
��E F
/
��G H
obj
��I L
.
��L M 
ParallaxMultiplier
��M _
,
��_ `
Camera
��a g
.
��g h
Translation
��h s
.
��s t
Y
��t u
/
��v w
obj
��x {
.
��{ |!
ParallaxMultiplier��| �
,��� �
Camera��� �
.��� �
Translation��� �
.��� �
Z��� �
/��� �
obj��� �
.��� �"
ParallaxMultiplier��� �
)��� �
)��� �
Else
�� 
sb
�� 
.
�� 
Begin
�� 
(
�� 
Nothing
�� $
,
��$ %

BlendState
��& 0
.
��0 1
NonPremultiplied
��1 A
,
��A B
SamplerState
��C O
.
��O P
LinearClamp
��P [
,
��[ \
Nothing
��] d
,
��d e
Nothing
��f m
,
��m n
Nothing
��o v
,
��v w
Camera
��x ~
.
��~ 
	GetMatrix�� �
(��� �
)��� �
)��� �
End
�� 
If
�� 
obj
�� 
.
�� 
Draw
�� 
(
�� 
sb
�� 
)
�� 
sb
�� 
.
�� 
End
�� 
(
�� 
)
�� 
Next
�� 
End
�� 
If
�� 
LevelSpecificCode
�� 
.
�� 
LevelSpecificCode
�� +
.
��+ ,
ExecuteDraw
��, 7
(
��7 8
sb
��8 :
)
��: ;
DrawShadowOverlay
�� 
(
�� 
sb
�� 
)
�� 
If
�� 

Keyboard
�� 
.
�� 
GetState
�� 
.
�� 
	IsKeyDown
�� &
(
��& '
Keys
��' +
.
��+ ,
O
��, -
)
��- .
Then
��/ 3
	TimeOfDay
�� 
+=
�� 
$num
�� 
	TimeOfDay
�� 
=
�� 
	TimeOfDay
�� !
Mod
��" %
$num
��& '
End
�� 
If
�� 
End
�� 
Sub
�� 
Private
�� 
Sub
�� 
DrawSky
�� 
(
�� 
sb
�� 
As
�� 
SpriteBatch
�� )
)
��) *
If
�� 

ShadowOverlay
�� 
Is
�� 
Nothing
�� #
Then
��$ (
ShadowOverlay
�� 
=
�� 
New
�� 
RenderTarget2D
��  .
(
��. /
graphics
��/ 7
.
��7 8
GraphicsDevice
��8 F
,
��F G
GetLevelSize
��H T
(
��T U
)
��U V
.
��V W
X
��W X
,
��X Y
GetLevelSize
��Z f
(
��f g
)
��g h
.
��h i
Y
��i j
)
��j k#
ShadowOverlayRenderer
�� !
.
��! "!
RenderShadowOverlay
��" 5
(
��5 6
sb
��6 8
,
��8 9
ShadowOverlay
��: G
,
��G H
LightPolygons
��I V
)
��V W
End
�� 
If
�� 
sb
�� 

.
��
 
Begin
�� 
(
�� 
,
�� 

BlendState
�� 
.
�� 
NonPremultiplied
�� .
,
��. /
SamplerState
��0 <
.
��< =

PointClamp
��= G
,
��G H
,
��H I
,
��I J
,
��J K
)
��K L
Dim
�� 
pixels
�� 
(
�� 
graphics
�� 
.
�� '
PreferredBackBufferHeight
�� 5
-
��6 7
$num
��8 9
)
��9 :
As
��; =
Color
��> C
For
�� 
i
�� 
As
�� 
Integer
�� 
=
�� 
$num
�� 
To
�� 
pixels
��  &
.
��& '
Length
��' -
-
��. /
$num
��0 1
pixels
�� 
(
�� 
i
�� 
)
�� 
=
�� 
Color
�� 
.
�� 
Lerp
�� "
(
��" #
Misc
��# '
.
��' (
SubtractColors
��( 6
(
��6 7
	SkyColors
��7 @
(
��@ A
CInt
��A E
(
��E F
	TimeOfDay
��F O
*
��P Q
$num
��R T
)
��T U
)
��U V
,
��V W
New
��X [
Color
��\ a
(
��a b
$num
��b e
,
��e f
$num
��g j
,
��j k
$num
��l o
)
��o p
)
��p q
,
��q r
	SkyColors
��s |
(
��| }
CInt��} �
(��� �
	TimeOfDay��� �
*��� �
$num��� �
)��� �
)��� �
,��� �
CSng��� �
(��� �
i��� �
/��� �
graphics��� �
.��� �)
PreferredBackBufferHeight��� �
)��� �
)��� �
Next
��  
BackgroundGradient
�� 
=
�� 
New
��  
	Texture2D
��! *
(
��* +
graphics
��+ 3
.
��3 4
GraphicsDevice
��4 B
,
��B C
$num
��D E
,
��E F
graphics
��G O
.
��O P'
PreferredBackBufferHeight
��P i
)
��i j 
BackgroundGradient
�� 
.
�� 
SetData
�� "
(
��" #
pixels
��# )
)
��) *
sb
�� 

.
��
 
Draw
�� 
(
��  
BackgroundGradient
�� "
,
��" #
New
��$ '
	Rectangle
��( 1
(
��1 2
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
graphics
��8 @
.
��@ A&
PreferredBackBufferWidth
��A Y
,
��Y Z
graphics
��[ c
.
��c d'
PreferredBackBufferHeight
��d }
)
��} ~
,
��~ 
Color��� �
.��� �
White��� �
)��� �
Dim
�� 
sunPos
�� 
As
�� 
New
�� 
Point
�� 
sunPos
�� 
.
�� 
X
�� 
=
�� 
CInt
�� 
(
�� 
	TimeOfDay
�� !
*
��" #
graphics
��$ ,
.
��, -&
PreferredBackBufferWidth
��- E
)
��E F
sunPos
�� 
.
�� 
Y
�� 
=
�� 
CInt
�� 
(
�� 
(
�� 
(
�� 
	TimeOfDay
�� #
*
��$ %
$num
��& '
-
��( )
$num
��* +
)
��+ ,
^
��- .
$num
��/ 0
+
��1 2
$num
��3 6
)
��6 7
*
��8 9
graphics
��: B
.
��B C'
PreferredBackBufferHeight
��C \
)
��\ ]
sb
�� 

.
��
 
Draw
�� 
(
�� 
Textures
�� 
.
�� 
Sun
�� 
,
�� 
New
�� !
	Rectangle
��" +
(
��+ ,
sunPos
��, 2
,
��2 3
New
��4 7
Point
��8 =
(
��= >
$num
��> A
,
��A B
$num
��C F
)
��F G
)
��G H
,
��H I
Color
��J O
.
��O P
White
��P U
)
��U V
For
�� 
i
�� 
As
�� 
Integer
�� 
=
�� 
$num
�� 
To
�� 
Clouds
��  &
.
��& '
Length
��' -
-
��. /
$num
��0 1
Clouds
�� 
(
�� 
i
�� 
)
�� 
.
�� 
Draw
�� 
(
�� 
sb
�� 
)
�� 
Clouds
�� 
(
�� 
i
�� 
)
�� 
.
�� 
Position
�� 
.
�� 
X
��  
+=
��! #
$num
��$ (
If
�� 
Clouds
�� 
(
�� 
i
�� 
)
�� 
.
�� 
Position
�� !
.
��! "
X
��" #
>
��$ %
graphics
��& .
.
��. /&
PreferredBackBufferWidth
��/ G
Then
��H L
Clouds
�� 
(
�� 
i
�� 
)
�� 
.
�� 
Position
�� "
.
��" #
X
��# $
=
��% &
Random
��' -
.
��- .
Next
��. 2
(
��2 3
CInt
��3 7
(
��7 8
-
��8 9
Clouds
��9 ?
(
��? @
i
��@ A
)
��A B
.
��B C
Texture
��C J
.
��J K
Width
��K P
*
��Q R
Clouds
��S Y
(
��Y Z
i
��Z [
)
��[ \
.
��\ ]
Scale
��] b
*
��c d
$num
��e f
)
��f g
,
��g h
CInt
��i m
(
��m n
-
��n o
Clouds
��o u
(
��u v
i
��v w
)
��w x
.
��x y
Texture��y �
.��� �
Width��� �
*��� �
Clouds��� �
(��� �
i��� �
)��� �
.��� �
Scale��� �
)��� �
)��� �
Clouds
�� 
(
�� 
i
�� 
)
�� 
.
�� 
Position
�� "
.
��" #
Y
��# $
=
��% &
Random
��' -
.
��- .
Next
��. 2
(
��2 3
$num
��3 5
,
��5 6
$num
��7 :
)
��: ;
End
�� 
If
�� 
Next
�� 
sb
�� 

.
��
 
End
�� 
(
�� 
)
�� 
End
�� 
Sub
�� 
Private
�� 
Sub
�� 
DrawShadowOverlay
�� !
(
��! "
sb
��" $
As
��% '
SpriteBatch
��( 3
)
��3 4
sb
�� 

.
��
 
Begin
�� 
(
�� 
,
�� 

BlendState
�� 
.
�� 
NonPremultiplied
�� .
,
��. /
,
��/ 0
,
��0 1
,
��1 2
,
��2 3
ScreenHandler
��4 A
.
��A B
SelectedScreen
��B P
.
��P Q
ToWorld
��Q X
.
��X Y
SelectedLevel
��Y f
.
��f g
Camera
��g m
.
��m n
	GetMatrix
��n w
(
��w x
)
��x y
)
��y z
Dim
�� 
alpha
�� 
As
�� 
Single
�� 
=
�� 
$num
�� 
-
��  !
CSng
��" &
(
��& '
-
��' (
(
��( )
	TimeOfDay
��) 2
*
��3 4
$num
��5 6
-
��7 8
$num
��9 :
)
��: ;
^
��< =
$num
��> ?
+
��@ A
$num
��B C
)
��C D
If
�� 

alpha
�� 
>
�� 
$num
�� 
Then
�� 
alpha
�� 
=
�� 
$num
�� 
End
�� 
If
�� 
sb
�� 

.
��
 
Draw
�� 
(
�� 
ShadowOverlay
�� 
,
�� 
New
�� "
Vector2
��# *
(
��* +
$num
��+ ,
,
��, -
$num
��. /
)
��/ 0
,
��0 1
Color
��2 7
.
��7 8
White
��8 =
*
��> ?
alpha
��@ E
)
��E F
Misc
�� 
.
�� 
DrawRectangle
�� 
(
�� 
sb
�� 
,
�� 
New
�� "
	Rectangle
��# ,
(
��, -
GetLevelSize
��- 9
(
��9 :
)
��: ;
.
��; <
X
��< =
,
��= >
$num
��? @
,
��@ A
$num
��B G
,
��G H
$num
��I M
)
��M N
,
��N O
Color
��P U
.
��U V
Black
��V [
*
��\ ]
alpha
��^ c
)
��c d
Misc
�� 
.
�� 
DrawRectangle
�� 
(
�� 
sb
�� 
,
�� 
New
�� "
	Rectangle
��# ,
(
��, -
$num
��- .
,
��. /
-
��0 1
$num
��1 5
,
��5 6
$num
��7 <
,
��< =
$num
��> B
)
��B C
,
��C D
Color
��E J
.
��J K
Black
��K P
*
��Q R
alpha
��S X
)
��X Y
Misc
�� 
.
�� 
DrawRectangle
�� 
(
�� 
sb
�� 
,
�� 
New
�� "
	Rectangle
��# ,
(
��, -
-
��- .
$num
��. 2
,
��2 3
-
��4 5
$num
��5 9
,
��9 :
$num
��; ?
,
��? @
$num
��A F
)
��F G
,
��G H
Color
��I N
.
��N O
Black
��O T
*
��U V
alpha
��W \
)
��\ ]
Misc
�� 
.
�� 
DrawRectangle
�� 
(
�� 
sb
�� 
,
�� 
New
�� "
	Rectangle
��# ,
(
��, -
$num
��- .
,
��. /
GetLevelSize
��0 <
(
��< =
)
��= >
.
��> ?
Y
��? @
,
��@ A
GetLevelSize
��B N
(
��N O
)
��O P
.
��P Q
X
��Q R
,
��R S
$num
��T X
)
��X Y
,
��Y Z
Color
��[ `
.
��` a
Black
��a f
*
��g h
alpha
��i n
)
��n o
sb
�� 

.
��
 
End
�� 
(
�� 
)
�� 
End
�� 
Sub
�� 
Dim
�� "
updatingWorldObjects
�� 
As
�� 
List
��  $
(
��$ %
Of
��% '
WorldObject
��( 3
)
��3 4
Public
�� 

Sub
�� 
Update
�� 
(
�� 
gameTime
�� 
As
�� !
GameTime
��" *
,
��* +
player
��, 2
As
��3 5
Player
��6 <
)
��< =
LevelSpecificCode
�� 
.
�� 
LevelSpecificCode
�� +
.
��+ ,
ExecuteUpdate
��, 9
(
��9 :
gameTime
��: B
)
��B C
If
�� 
"
updatingWorldObjects
�� 
Is
��  "
Nothing
��# *
Then
��+ /"
updatingWorldObjects
��  
=
��! "
New
��# &
List
��' +
(
��+ ,
Of
��, .
WorldObject
��/ :
)
��: ;
For
�� 
Each
�� 
wObj
�� 
In
�� 
PlacedObjects
�� *
If
�� 
wObj
�� 
IsNot
�� 
Nothing
�� %
Then
��& *"
updatingWorldObjects
�� (
.
��( )
Add
��) ,
(
��, -
wObj
��- 1
)
��1 2
End
�� 
If
�� 
Next
�� 
End
�� 
If
�� 
For
�� 
Each
�� 
wObj
�� 
In
�� "
updatingWorldObjects
�� -
wObj
�� 
.
�� 
Update
�� 
(
�� 
gameTime
��  
)
��  !
Next
�� 
For
�� 
Each
�� 
NPC
�� 
In
�� 
NPCs
�� 
NPC
�� 
.
�� 
Update
�� 
(
�� 
gameTime
�� 
)
��  
Next
�� 
NPCs
�� 
.
�� 
	RemoveAll
�� 
(
�� 
Function
�� 
(
��  
x
��  !
)
��! "
x
��# $
.
��$ %
Alive
��% *
=
��+ ,
False
��- 2
)
��2 3
End
�� 
Sub
�� 
Public
�� 

Sub
�� 
Explode
�� 
(
�� 
	centerPos
��  
As
��! #
Vector2
��$ +
,
��+ ,
radius
��- 3
As
��4 6
Integer
��7 >
)
��> ?
Throw
�� 
New
�� %
NotImplementedException
�� )
(
��) *
$str
��* j
)
��j k
End
�� 
Sub
�� 
Public
�� 

Function
�� 
GetLevelSize
��  
(
��  !
)
��! "
As
��# %
Point
��& +
Return
�� 
New
�� 
Point
�� 
(
�� 
	LevelMaxX
�� "
,
��" #
	LevelMaxY
��$ -
)
��- .
End
�� 
Function
�� 
Public
�� 

Function
�� 
GetScreenRect
�� !
(
��! "
)
��" #
As
��$ &
	Rectangle
��' 0
Dim
�� 
selectedLevel
�� 
=
�� 
ScreenHandler
�� )
.
��) *
SelectedScreen
��* 8
.
��8 9
ToWorld
��9 @
(
��@ A
)
��A B
.
��B C
SelectedLevel
��C P
Return
�� 
New
�� 
	Rectangle
�� 
(
�� 
CInt
�� !
(
��! "
selectedLevel
��" /
.
��/ 0
Camera
��0 6
.
��6 7
Translation
��7 B
.
��B C
X
��C D
)
��D E
,
��E F
CInt
�� !
(
��! "
selectedLevel
��" /
.
��/ 0
Camera
��0 6
.
��6 7
Translation
��7 B
.
��B C
Y
��C D
)
��D E
,
��E F
GetLevelSize
�� )
(
��) *
)
��* +
.
��+ ,
X
��, -
,
��- .
GetLevelSize
��/ ;
(
��; <
)
��< =
.
��= >
Y
��> ?
)
��? @
End
�� 
Function
�� 
End�� 
Class
�� 	�s
�C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\WorldHandling\LevelHandling\LevelLoader.vb
Public		 
Class		 
LevelLoader		 
Shared

 

TextureObjs

 
As

 
List

 
(

 
Of

 !
TextureObject

" /
)

/ 0
Public 

Shared 
Function 
	LoadLevel $
($ %
path% )
As* ,
String- 3
,3 4
Content5 <
As= ?
ContentManager@ N
)N O
AsP R
LevelS X
Dim 
_placedObjects 
As 
New !
List" &
(& '
Of' )
WorldObject* 5
)5 6
Dim 
lvlXEle 
= 
XElement 
. 
Load #
(# $
path$ (
)( )
For 
Each 
xele 
In 
lvlXEle  
.  !
Element! (
(( )
$str) 7
)7 8
.8 9
Elements9 A
Dim 

_placedObj 
As 
New !
WorldObject" -

_placedObj 
. 
Name 
= 
xele "
." #
	Attribute# ,
(, -
$str- 3
)3 4
.4 5
Value5 :

_placedObj 
. 
rect 
. 
X 
= 
CInt  $
($ %
xele% )
.) *
Element* 1
(1 2
$str2 5
)5 6
.6 7
Value7 <
)< =

_placedObj 
. 
rect 
. 
Y 
= 
CInt  $
($ %
xele% )
.) *
Element* 1
(1 2
$str2 5
)5 6
.6 7
Value7 <
)< =

_placedObj 
. 
rect 
. 
Width !
=" #
CInt$ (
(( )
xele) -
.- .
Element. 5
(5 6
$str6 =
)= >
.> ?
Value? D
)D E

_placedObj 
. 
rect 
. 
Height "
=# $
CInt% )
() *
xele* .
.. /
Element/ 6
(6 7
$str7 ?
)? @
.@ A
ValueA F
)F G

_placedObj 
. 
Scale 
= 
CInt #
(# $
xele$ (
.( )
Element) 0
(0 1
$str1 8
)8 9
.9 :
Value: ?
)? @

_placedObj 
. 
zIndex 
= 
CInt  $
($ %
xele% )
.) *
Element* 1
(1 2
$str2 ;
); <
.< =
Value= B
)B C

_placedObj   
.   
ParallaxMultiplier   )
=  * +
Single  , 2
.  2 3
Parse  3 8
(  8 9
xele  9 =
.  = >
Element  > E
(  E F
$str  F Z
)  Z [
.  [ \
Value  \ a
)  a b

_placedObj!! 
.!! 
IsProp!! 
=!! 
Boolean!!  '
.!!' (
Parse!!( -
(!!- .
xele!!. 2
.!!2 3
Element!!3 :
(!!: ;
$str!!; C
)!!C D
.!!D E
Value!!E J
)!!J K
_placedObjects## 
.## 
Add## 
(## 

_placedObj## )
)##) *
Next$$ 
LoadTextures&& 
(&& 
Content&& 
,&& 
lvlXEle&& %
)&&% &
For(( 
Each(( 
wObj(( 
In(( 
_placedObjects(( '
For)) 
Each)) 
tObj)) 
In)) 
TextureObjs)) (
If** 
wObj** 
.** 
Name** 
=** 
tObj** #
.**# $
Name**$ (
Then**) -
wObj++ 
.++ 
Texture++  
=++! "
tObj++# '
.++' (
Texture++( /
wObj-- 
.-- $
HasRandomTextureRotation-- 1
=--2 3
tObj--4 8
.--8 9$
HasRandomTextureRotation--9 Q
wObj.. 
... 
	IsFoliage.. "
=..# $
tObj..% )
...) *
	IsFoliage..* 3
wObj00 
.00 
RotateRandomly00 '
(00' (
)00( )
End11 
If11 
Next22 
Next33 
For77 
Each77 
xele77 
In77 
XElement77 !
.77! "
Load77" &
(77& '
path77' +
)77+ ,
.77, -
Element77- 4
(774 5
$str775 G
)77G H
.77H I
Elements77I Q
Select88 
Case88 
xele88 
.88 
	Attribute88 &
(88& '
$str88' -
)88- .
.88. /
Value88/ 4
Case99 
$str99 "
Dim:: 
tObj:: 
As:: 
New::  #
PlayerSpawn::$ /
tObj;; 
.;; 
Name;; 
=;; 
xele;;  $
.;;$ %
	Attribute;;% .
(;;. /
$str;;/ 5
);;5 6
.;;6 7
Value;;7 <
tObj<< 
.<< 
rect<< 
.<< 
X<< 
=<<  !
CInt<<" &
(<<& '
xele<<' +
.<<+ ,
Element<<, 3
(<<3 4
$str<<4 7
)<<7 8
.<<8 9
Value<<9 >
)<<> ?
tObj== 
.== 
rect== 
.== 
Y== 
===  !
CInt==" &
(==& '
xele==' +
.==+ ,
Element==, 3
(==3 4
$str==4 7
)==7 8
.==8 9
Value==9 >
)==> ?
_placedObjects?? "
.??" #
Add??# &
(??& '
tObj??' +
)??+ ,
CaseAA 
$strAA 
DimBB 
tObjBB 
AsBB 
NewBB  #
SpawnerBB$ +
tObjCC 
.CC 
NameCC 
=CC 
xeleCC  $
.CC$ %
	AttributeCC% .
(CC. /
$strCC/ 5
)CC5 6
.CC6 7
ValueCC7 <
tObjDD 
.DD 
rectDD 
.DD 
XDD 
=DD  !
CIntDD" &
(DD& '
xeleDD' +
.DD+ ,
ElementDD, 3
(DD3 4
$strDD4 7
)DD7 8
.DD8 9
ValueDD9 >
)DD> ?
tObjEE 
.EE 
rectEE 
.EE 
YEE 
=EE  !
CIntEE" &
(EE& '
xeleEE' +
.EE+ ,
ElementEE, 3
(EE3 4
$strEE4 7
)EE7 8
.EE8 9
ValueEE9 >
)EE> ?
tObjFF 
.FF 
IDFF 
=FF 
xeleFF "
.FF" #
ElementFF# *
(FF* +
$strFF+ /
)FF/ 0
.FF0 1
ValueFF1 6
_placedObjectsHH "
.HH" #
AddHH# &
(HH& '
tObjHH' +
)HH+ ,
CaseJJ 
$strJJ %
DimKK 
tObjKK 
AsKK 
NewKK  #
InfoBoxDisplayKK$ 2
tObjLL 
.LL 
NameLL 
=LL 
xeleLL  $
.LL$ %
	AttributeLL% .
(LL. /
$strLL/ 5
)LL5 6
.LL6 7
ValueLL7 <
tObjMM 
.MM 
rectMM 
.MM 
XMM 
=MM  !
CIntMM" &
(MM& '
xeleMM' +
.MM+ ,
ElementMM, 3
(MM3 4
$strMM4 7
)MM7 8
.MM8 9
ValueMM9 >
)MM> ?
tObjNN 
.NN 
rectNN 
.NN 
YNN 
=NN  !
CIntNN" &
(NN& '
xeleNN' +
.NN+ ,
ElementNN, 3
(NN3 4
$strNN4 7
)NN7 8
.NN8 9
ValueNN9 >
)NN> ?
tObjOO 
.OO 
TextOO 
=OO 
xeleOO  $
.OO$ %
ElementOO% ,
(OO, -
$strOO- 3
)OO3 4
.OO4 5
ValueOO5 :
.OO: ;
ReplaceOO; B
(OOB C
$strOOC G
,OOG H
	vbNewLineOOI R
)OOR S
_placedObjectsQQ "
.QQ" #
AddQQ# &
(QQ& '
tObjQQ' +
)QQ+ ,
CaseSS 
$strSS "
DimTT 
tObjTT 
AsTT 
NewTT  #
LoadingZoneTT$ /
tObjUU 
.UU 
NameUU 
=UU 
xeleUU  $
.UU$ %
	AttributeUU% .
(UU. /
$strUU/ 5
)UU5 6
.UU6 7
ValueUU7 <
tObjVV 
.VV 
rectVV 
.VV 
XVV 
=VV  !
CIntVV" &
(VV& '
xeleVV' +
.VV+ ,
ElementVV, 3
(VV3 4
$strVV4 7
)VV7 8
.VV8 9
ValueVV9 >
)VV> ?
tObjWW 
.WW 
rectWW 
.WW 
YWW 
=WW  !
CIntWW" &
(WW& '
xeleWW' +
.WW+ ,
ElementWW, 3
(WW3 4
$strWW4 7
)WW7 8
.WW8 9
ValueWW9 >
)WW> ?
tObjXX 
.XX 
TargetLevelNameXX (
=XX) *
xeleXX+ /
.XX/ 0
ElementXX0 7
(XX7 8
$strXX8 I
)XXI J
.XXJ K
ValueXXK P
_placedObjectsZZ "
.ZZ" #
AddZZ# &
(ZZ& '
tObjZZ' +
)ZZ+ ,
End[[ 
Select[[ 
Next\\ 
Dim^^ 
lvl^^ 
As^^ 
New^^ 
Level^^ 
(^^ 
_placedObjects^^ +
)^^+ ,
If__ 

lvlXEle__ 
.__ 
Element__ 
(__ 
$str__ '
)__' (
.__( )
Element__) 0
(__0 1
$str__1 F
)__F G
.__G H
Value__H M
<>__N P
$str__Q S
Then__T X
lvl`` 
.`` 
BackgroundImage`` 
=``  !
TextureLoader``" /
.``/ 0
Load``0 4
(``4 5
lvlXEle``5 <
.``< =
Element``= D
(``D E
$str``E Q
)``Q R
.``R S
Element``S Z
(``Z [
$str``[ p
)``p q
.``q r
Value``r w
)``w x
Endaa 
Ifaa 
lvlbb 
.bb 
LightPolygonsbb 
=bb 
LoadLightPolygonsbb -
(bb- .
lvlXElebb. 5
.bb5 6
Elementbb6 =
(bb= >
$strbb> M
)bbM N
)bbN O
Returndd 
lvldd 
Endff 
Functionff 
Sharedhh 

Subhh 
LoadTextureshh 
(hh 
Contenthh #
Ashh$ &
ContentManagerhh' 5
,hh5 6
lvlXElehh7 >
Ashh? A
XElementhhB J
)hhJ K
Dimii 

resultObjsii 
Asii 
Newii 
Listii "
(ii" #
Ofii# %
TextureObjectii& 3
)ii3 4
Formm 
Eachmm 
_tObjmm 
Inmm 
lvlXElemm !
.mm! "
Elementmm" )
(mm) *
$strmm* 4
)mm4 5
.mm5 6
Elementsmm6 >

resultObjsnn 
.nn 
Addnn 
(nn 
Newnn 
TextureObjectnn ,
(nn, -
_tObjnn- 2
.nn2 3
Elementnn3 :
(nn: ;
$strnn; A
)nnA B
.nnB C
ValuennC H
,nnH I
TextureLoaderoo- :
.oo: ;
Loadoo; ?
(oo? @
_tObjoo@ E
.ooE F
ElementooF M
(ooM N
$strooN [
)oo[ \
.oo\ ]
Valueoo] b
)oob c
,ooc d
Convertpp- 4
.pp4 5
	ToBooleanpp5 >
(pp> ?
_tObjpp? D
.ppD E
ElementppE L
(ppL M
$strppM d
)ppd e
.ppe f
Valueppf k
)ppk l
,ppl m
Convertqq- 4
.qq4 5
	ToBooleanqq5 >
(qq> ?
_tObjqq? D
.qqD E
ElementqqE L
(qqL M
$strqqM X
)qqX Y
.qqY Z
ValueqqZ _
)qq_ `
)qq` a
)qqa b
Nextrr 
TextureObjstt 
=tt 

resultObjstt  
Enduu 
Subuu 
Sharedww 

Functionww 
LoadLightPolygonsww %
(ww% &
xelePolygonsww& 2
Asww3 5
XElementww6 >
)ww> ?
Asww@ B
ListwwC G
(wwG H
OfwwH J
PolygonwwK R
)wwR S
Dimxx 
lightPolygonsxx 
=xx 
Newxx 
Listxx  $
(xx$ %
Ofxx% '
Polygonxx( /
)xx/ 0
Forzz 
Eachzz 
xelePzz 
Inzz 
xelePolygonszz &
.zz& '
Elementszz' /
(zz/ 0
$strzz0 9
)zz9 :
Dim|| 

tmpPolygon|| 
As|| 
New|| !
Polygon||" )
For~~ 
Each~~ 
xeleC~~ 
In~~ 
xeleP~~ #
.~~# $
Elements~~$ ,
(~~, -
$str~~- 5
)~~5 6

tmpPolygon 
. 
corners "
." #
Add# &
(& '
New' *
Vector2+ 2
(2 3
CInt3 7
(7 8
xeleC8 =
.= >
Element> E
(E F
$strF I
)I J
)J K
,K L
CIntM Q
(Q R
xeleCR W
.W X
ElementX _
(_ `
$str` c
)c d
)d e
)e f
)f g
Next
�� 
lightPolygons
�� 
.
�� 
Add
�� 
(
�� 

tmpPolygon
�� (
)
��( )
Next
�� 
Return
�� 
lightPolygons
�� 
End
�� 
Function
�� 
End�� 
Class
�� 	�-
mC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\WorldHandling\World.vb
Public 
Class 
World 
Inherits 
Screen 
Public 

Levels 
As 
New 
List 
( 
Of  
Level! &
)& '
Private 
_selectedLevel 
As 
Level #
Public 

Player 
As 
New 
Player 
With  $
{% &
.& '
Scale' ,
=- .
$num/ 0
,0 1
.2 3
Position3 ;
=< =
New> A
Vector2B I
(I J
$numJ M
,M N
$numO P
)P Q
}Q R
Public 

Property 
SelectedLevel !
As" $
Level% *
Get 
Return 
_selectedLevel !
End 
Get 
Set 
( 
value 
As 
Level 
) 
_selectedLevel 
= 
value "
For 
Each 
wObj 
In 
value "
." #
PlacedObjects# 0
If   
wObj   
.   
GetType   
=    !
GetType  " )
(  ) *
PlayerSpawn  * 5
)  5 6
Then  7 ;
Player!! 
.!! 
Position!! #
=!!$ %
wObj!!& *
.!!* +
GetTrueRect!!+ 6
.!!6 7
Location!!7 ?
.!!? @
	ToVector2!!@ I
End"" 
If"" 
Next## 
End$$ 
Set$$ 
End%% 
Property%% 
Public-- 

Sub-- 
	LoadLevel-- 
(-- 
path-- 
As--  
String--! '
,--' (
name--) -
As--. 0
String--1 7
,--7 8
Content--9 @
As--A C
ContentManager--D R
)--R S
Dim// 
lvl// 
=// 
LevelLoader// 
.// 
	LoadLevel// '
(//' (
path//( ,
,//, -
Content//. 5
)//5 6
lvl00 
.00 
Name00 
=00 
name00 
Levels22 
.22 
Add22 
(22 
lvl22 
)22 
End33 
Sub33 
Public:: 

Sub:: 
LoadContent:: 
(:: 
Content:: "
As::# %
ContentManager::& 4
)::4 5
For;; 
Each;; 
_level;; 
In;; 
Levels;; !
_level<< 
.<< 
LoadContent<< 
(<< 
Content<< &
)<<& '
Next== 
End>> 
Sub>> 
Public@@ 

	Overrides@@ 
Sub@@ 
Draw@@ 
(@@ 
sb@@  
As@@! #
SpriteBatch@@$ /
)@@/ 0
IfBB 

SelectedLevelBB 
IsNotBB 
NothingBB &
ThenBB' +
SelectedLevelCC 
.CC 
DrawCC 
(CC 
sbCC !
,CC! "
PlayerCC# )
)CC) *
EndDD 
IfDD 
sbGG 

.GG
 
BeginGG 
(GG 
)GG 
DrawUIII 
(II 
sbII 
)II 
ForKK 
EachKK 
NPCKK 
InKK 
SelectedLevelKK %
.KK% &
NPCsKK& *
NPCLL 
.LL 
DrawDialogueLL 
(LL 
sbLL 
)LL  
NextMM 
sbOO 

.OO
 
EndOO 
(OO 
)OO 
SelectedLevelQQ 
.QQ 
CameraQQ 
.QQ 
FocusOnObjectQQ *
(QQ* +
PlayerQQ+ 1
)QQ1 2
EndRR 
SubRR 
PublicTT 

	OverridesTT 
SubTT 
UpdateTT 
(TT  
gameTimeTT  (
AsTT) +
GameTimeTT, 4
)TT4 5
IfUU 

SelectedLevelUU 
IsNotUU 
NothingUU &
ThenUU' +
SelectedLevelVV 
.VV 
UpdateVV  
(VV  !
gameTimeVV! )
,VV) *
PlayerVV+ 1
)VV1 2
PlayerWW 
.WW 
UpdateWW 
(WW 
gameTimeWW "
)WW" #
IfYY 
PlayerYY 
.YY 
HealthPointsYY "
<YY# $
$numYY% &
ThenYY' +
MsgBoxZZ 
(ZZ 
$strZZ .
)ZZ. /
End\\ 
If\\ 
End]] 
If]] 
End^^ 
Sub^^ 
Publicbb 

Subbb 
DrawUIbb 
(bb 
_sbbb 
Asbb 
SpriteBatchbb (
)bb( )
_sbcc 
.cc 

DrawStringcc 
(cc 
Fontscc 
.cc 
ChakraPetchcc (
.cc( )
Normalcc) /
,cc/ 0
Playercc1 7
.cc7 8
Weaponcc8 >
.cc> ?
ProjectilesInMagcc? O
&ccP Q
$strccR U
&ccV W
PlayerccX ^
.cc^ _
Weaponcc_ e
.cce f
ProjectilesMagMaxccf w
,ccw x
Newccy |
Vector2	cc} �
(
cc� �
$num
cc� �
,
cc� �
$num
cc� �
)
cc� �
,
cc� �
Color
cc� �
.
cc� �
Black
cc� �
)
cc� �
Enddd 
Subdd 
Endee 
Classee 	�
sC:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\WorldHandling\WorldLoader.vb
Public 
Class 
WorldLoader 
Public 

Shared 
Function 
	LoadWorld $
($ %
_path% *
As+ -
String. 4
,4 5
Content6 =
As> @
ContentManagerA O
)O P
AsQ S
WorldT Y
Dim 
resultWorld 
As 
New 
World $
Dim		 
file		 
As		 
XElement		 
=		 
XElement		 '
.		' (
Load		( ,
(		, -
_path		- 2
)		2 3
Dim 
levelsFolderPath 
As 
String  &
=' (
Path) -
.- .
Combine. 5
(5 6
Path6 :
.: ;
GetDirectoryName; K
(K L
_pathL Q
)Q R
,R S
$strT \
)\ ]
For 
Each 
xele 
As 
XElement !
In" $
file% )
.) *
Element* 1
(1 2
$str2 :
): ;
.; <
Elements< D
resultWorld 
. 
	LoadLevel !
(! "
Path" &
.& '
Combine' .
(. /
levelsFolderPath/ ?
,? @
xeleA E
.E F
ElementF M
(M N
$strN T
)T U
.U V
ValueV [
&\ ]
$str^ e
)e f
,f g
xeleh l
.l m
Elementm t
(t u
$stru {
){ |
.| }
Value	} �
,
� �
Content
� �
)
� �
Next 
Return 
resultWorld 
End 
Function 
End 
Class 	�L
�C:\Users\Lukas\source\repos\XnaPlatformerEngine\XnaPlatformerEngine\src\ScreenHandling\WorldHandling\LevelHandling\Objects\WorldObject.vb
Public 
Class 
WorldObject 
Inherits 
Sprite 
Public 

rect 
As 
	Rectangle 
Public		 

zIndex		 
As		 
Integer		 
=		 
$num		  
Public 

IsPlayerInRange 
As 
Boolean %
=& '
False( -
Public 
$
HasRandomTextureRotation #
As$ &
Boolean' .
=/ 0
False1 6
Public 

	IsFoliage 
As 
Boolean 
=  !
False" '
Public 

Rotation 
As 
Single 
= 
$num  !
Public 

ParallaxMultiplier 
As  
Single! '
=( )
$num* .
Public 

IsProp 
As 
Boolean 
= 
False $
Sub 
New 
( 
) 
RotateRandomly 
( 
) 
End 
Sub 
Public 

Sub 
RotateRandomly 
( 
) 
If 
$
HasRandomTextureRotation #
Then$ (
Rotation 
= 
CSng 
( 
Random "
." #
Next# '
(' (
$num( )
,) *
$num+ ,
), -
*. /
Math0 4
.4 5
PI5 7
/8 9
$num: ;
); <
End 
If 
End 
Sub 
Public!! 

	Overrides!! 
Sub!! 
Update!! 
(!!  
gameTime!!  (
As!!) +
GameTime!!, 4
)!!4 5
End"" 
Sub"" 
Public$$ 

Overridable$$ 
Sub$$ 
Interaction$$ &
($$& '
)$$' (
End%% 
Sub%% 
Public'' 

	Overrides'' 
Sub'' 
Draw'' 
('' 
sb''  
As''! #
SpriteBatch''$ /
)''/ 0
If(( 

Texture(( 
IsNot(( 
Nothing((  
Then((! %
If)) 
Not)) 
IsProp)) 
Then)) 
sb++ 
.++ 
Draw++ 
(++ 
Texture++ 
,++  
New++! $
	Rectangle++% .
(++. /
CInt++/ 3
(++3 4
rect++4 8
.++8 9
X++9 :
*++; <
$num++= ?
+++@ A
rect++B F
.++F G
Width++G L
/++M N
$num++O P
)++P Q
,++Q R
CInt++S W
(++W X
rect++X \
.++\ ]
Y++] ^
*++_ `
$num++a c
+++d e
rect++f j
.++j k
Height++k q
/++r s
$num++t u
)++u v
,++v w
CInt++x |
(++| }
rect	++} �
.
++� �
Width
++� �
*
++� �
Scale
++� �
)
++� �
,
++� �
CInt
++� �
(
++� �
rect
++� �
.
++� �
Height
++� �
*
++� �
Scale
++� �
)
++� �
)
++� �
,
++� �
Nothing
++� �
,
++� �
Color
++� �
.
++� �
White
++� �
,
++� �
Rotation
++� �
,
++� �
New
++� �
Vector2
++� �
(
++� �
CSng
++� �
(
++� �
Texture
++� �
.
++� �
Width
++� �
/
++� �
$num
++� �
)
++� �
,
++� �
CSng
++� �
(
++� �
Texture
++� �
.
++� �
Height
++� �
/
++� �
$num
++� �
)
++� �
)
++� �
,
++� �
Nothing
++� �
,
++� �
Nothing
++� �
)
++� �
Else,, 
sb.. 
... 
Draw.. 
(.. 
Texture.. 
,..  
New..! $
	Rectangle..% .
(... /
CInt../ 3
(..3 4
Position..4 <
...< =
X..= >
+..? @
rect..A E
...E F
Width..F K
/..L M
$num..N O
)..O P
,..P Q
CInt..R V
(..V W
Position..W _
..._ `
Y..` a
+..b c
rect..d h
...h i
Height..i o
/..p q
$num..r s
)..s t
,..t u
CInt..v z
(..z {
rect..{ 
.	.. �
Width
..� �
*
..� �
Scale
..� �
)
..� �
,
..� �
CInt
..� �
(
..� �
rect
..� �
.
..� �
Height
..� �
*
..� �
Scale
..� �
)
..� �
)
..� �
,
..� �
Nothing
..� �
,
..� �
Color
..� �
.
..� �
White
..� �
,
..� �
Rotation
..� �
,
..� �
New
..� �
Vector2
..� �
(
..� �
CSng
..� �
(
..� �
Texture
..� �
.
..� �
Width
..� �
/
..� �
$num
..� �
)
..� �
,
..� �
CSng
..� �
(
..� �
Texture
..� �
.
..� �
Height
..� �
/
..� �
$num
..� �
)
..� �
)
..� �
,
..� �
Nothing
..� �
,
..� �
Nothing
..� �
)
..� �
End// 
If// 
Else22 
Misc33 
.33 
DrawOutline33 
(33 
sb33 
,33  
New33! $
	Rectangle33% .
(33. /
CInt33/ 3
(333 4
rect334 8
.338 9
X339 :
*33; <
$num33= ?
)33? @
,33@ A
CInt33B F
(33F G
rect33G K
.33K L
Y33L M
*33N O
$num33P R
)33R S
,33S T
CInt33U Y
(33Y Z
rect33Z ^
.33^ _
Width33_ d
*33e f
Scale33g l
)33l m
,33m n
CInt33o s
(33s t
rect33t x
.33x y
Height33y 
*
33� �
Scale
33� �
)
33� �
)
33� �
,
33� �
Color
33� �
.
33� �
Red
33� �
,
33� �
$num
33� �
)
33� �
End44 
If44 
End55 
Sub55 
Public77 

Function77 
ShallowCopy77 
(77  
)77  !
As77" $
WorldObject77% 0
Return88 

DirectCast88 
(88 
Me88 
.88 
MemberwiseClone88 ,
,88, -
WorldObject88. 9
)889 :
End99 
Function99 
Public;; 

	Overrides;; 
Function;; 
GetScreenRect;; +
(;;+ ,
);;, -
As;;. 0
	Rectangle;;1 :
Dim<< 
selectedLevel<< 
=<< 
ScreenHandler<< )
.<<) *
SelectedScreen<<* 8
.<<8 9
ToWorld<<9 @
.<<@ A
SelectedLevel<<A N
If>> 

IsProp>> 
Then>> 
Return?? 
New?? 
	Rectangle??  
(??  !
CInt??! %
(??% &
Position??& .
.??. /
X??/ 0
+??1 2
selectedLevel??3 @
.??@ A
Camera??A G
.??G H
Translation??H S
.??S T
X??T U
)??U V
,??V W
CInt??X \
(??\ ]
Position??] e
.??e f
Y??f g
+??h i
selectedLevel??j w
.??w x
Camera??x ~
.??~ 
Translation	?? �
.
??� �
Y
??� �
)
??� �
,
??� �
rect
??� �
.
??� �
Width
??� �
,
??� �
rect
??� �
.
??� �
Height
??� �
)
??� �
Else@@ 
ReturnAA 
NewAA 
	RectangleAA  
(AA  !
CIntAA! %
(AA% &
rectAA& *
.AA* +
XAA+ ,
*AA- .
$numAA/ 1
+AA2 3
selectedLevelAA4 A
.AAA B
CameraAAB H
.AAH I
TranslationAAI T
.AAT U
XAAU V
)AAV W
,AAW X
CIntAAY ]
(AA] ^
rectAA^ b
.AAb c
YAAc d
*AAe f
$numAAg i
+AAj k
selectedLevelAAl y
.AAy z
Camera	AAz �
.
AA� �
Translation
AA� �
.
AA� �
Y
AA� �
)
AA� �
,
AA� �
rect
AA� �
.
AA� �
Width
AA� �
,
AA� �
rect
AA� �
.
AA� �
Height
AA� �
)
AA� �
EndBB 
IfBB 
EndCC 
FunctionCC 
PublicEE 

	OverridesEE 
FunctionEE 
GetTrueRectEE )
(EE) *
)EE* +
AsEE, .
	RectangleEE/ 8
ReturnFF 
NewFF 
	RectangleFF 
(FF 
rectFF !
.FF! "
XFF" #
*FF$ %
$numFF& (
,FF( )
rectFF* .
.FF. /
YFF/ 0
*FF1 2
$numFF3 5
,FF5 6
rectFF7 ;
.FF; <
WidthFF< A
,FFA B
rectFFC G
.FFG H
HeightFFH N
)FFN O
EndGG 
FunctionGG 
EndHH 
ClassHH 	