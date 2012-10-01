@BranchToThumb
add r0,pc,#0x1
bx  r0
.thumb

ldr     r0,pointer          ;@ r0 = pointer address (0x02111880)
ldr     r0,[r0]             ;@ Load the address at the pointer
cmp     r0,#0x0             ;@ Check to see if we're at the game's menu / not in the game
beq     exit                ;@ If we are, exit
adr     r1,code_data        ;@ r1 will hold some data that we're using in the code
ldrh    r3,[r1]             ;@ r3 = master ball offset
add     r0,r0,r3            ;@ r0 = Poke ball bag slot 1 (AddressAtPointer + 0x0D14)
ldr     r5,io_keys          ;@ r5 = io_keys (0x04000130)
ldrh    r3,[r1,#0x2]        ;@ r3 = L+R (0x0300)
ldrh    r2,[r5,#0x0]        ;@ r2 = value at io_keys
tst     r2,r3               ;@ Check if L+R has been pressed
bne     check_select        ;@ If not, goto check_select; if so,
ldr     r4,master_ball      ;@ Load the master ball in r4
str     r4,[r0,#0x0]        ;@ and store it;
ldr     r4,ultra_ball       ;@ Load the ultra ball in r4
str     r4,[r0,#0x4]        ;@ and store it;
ldr     r4,great_ball       ;@ Load the great ball in r4
str     r4,[r0,#0x8]        ;@ and store it
check_select:               ;@ check_select label reached
ldrh    r3,[r1,#0x4]        ;@ r3 = Select (0x0004)
tst     r2,r3               ;@ Check if Select has been pressed
bne     exit                ;@ If not, exit
ldrb    r2,[r0,#0x0]        ;@ r2 = bag slot 1 value
ldrb    r3,[r0,#0x4]        ;@ r3 = bag slot 2 value
ldrb    r4,[r0,#0x8]        ;@ r4 = bag slot 3 value
cmp     r2,#0x1             ;@ Check if bag slot 1 has a master ball
bne     exit                ;@ If not, exit
cmp     r3,#0x2             ;@ Check if bag slot 2 has an ultra ball
bne     exit                ;@ If not, exit
cmp     r4,#0x3             ;@ Check if bag slot 3 has a great ball
bne     exit                ;@ If not, exit
ldrh    r2,[r0,#0x2]        ;@ r2 = bag slot 1 quantity
ldrh    r3,[r0,#0x6]        ;@ r3 = bag slot 2 quantity
ldrh    r4,[r0,#0xA]        ;@ r4 = bag slot 3 quantity
cmp     r2,#0x12            ;@ Do we have more than 18 master balls?
bgt     exit                ;@ If so, exit
cmp     r3,#0x1E            ;@ Do we have more than 30 ultra balls?
bgt     exit                ;@ If so, exit
cmp     r4,#0x1E            ;@ Do we have more than 30 great balls?
bgt     exit                ;@ If so, exit
ldrh    r5,[r1,#0x6]        ;@ r5 = 0xE9FC (0xF710 - 0x0D14)
add     r0,r0,r5            ;@ r0 = r0 + r5 (the first pc box slot)
mov     r5,#0x10            ;@ r5 = 0x10
lsl     r5,r5,#8            ;@ r5 = 0x10 << 0x8 = 0x1000 (PC Box Offset)
mul     r2,r2,r5            ;@ r2 = r2 * r5 (pc box * pc box offset)
sub     r2,r2,r5            ;@ r2 = r2 - r5 (pc box slot - 0x1000 because 1 master ball should = 1st pc box)
add     r0,r0,r2            ;@ r0 = r0 + r2 (now we have the correct pc box based on the amount of master balls we have)
mov     r5,#0x88            ;@ r5 = 0x88
mul     r3,r3,r5            ;@ r3 = r3 * r5 (starting slot * pc box slot offset)
mul     r4,r4,r5            ;@ r4 = r4 * r5 (ending slot * pc box slot offset)
sub     r3,r3,r5            ;@ r3 = r3 - r5 (starting slot - 0x88 because 1 ultra ball should = pc box slot 1)
add     r3,r3,r0            ;@ r3 = r3 + r0 (starting slot + base)
add     r4,r4,r0            ;@ r4 = r4 + r0 (ending slot + base)
mov     r2,#0x0             ;@ r2 = 0x0 (no data/no pokemon)
loop:                       ;@ loop
str     r2,[r3]             ;@ Store r2 into r3 (our starting slot)
add     r3,#0x4             ;@ Add r3 by 4 (word aligned)
cmp     r3,r4               ;@ Are we at the end (ending slot) ?
bne     loop                ;@ If not, loop again
exit:                       ;@ exit label reached
bx      lr                  ;@ return

.arm
pointer:
.word 0x02111880
code_data:
.word 0x03000D14
.word 0xE9FC0004
io_keys:
.word 0x04000130
master_ball:
.word 0x00120001
ultra_ball:
.word 0x001E0002
great_ball:
.word 0x001E0003