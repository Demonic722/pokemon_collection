ldr     r0,pointer          ;@ r0 = pointer address (0x02000024)
ldr     r0,[r0]             ;@ load the address at the pointer
cmp     r0,#0x0             ;@ check to see if we're at the game's menu / not in the game
bxeq    lr                  ;@ if we are, exit
ldr     r1,bag_slot         ;@ load the bag_slot offset
add     r0,r0,r1            ;@ and add it to the address at the pointer so we get the correct address
ldr     r5,io_keys          ;@ r5 = io_keys (0x04000130)
ldrh    r5,[r5]             ;@ load our current pressed / held buttons
tst     r5,#0x300           ;@ has L+R been pressed / held?
bne     check_select        ;@ if not, check if Select has been pressed or held
ldr     r1,master_ball      ;@ else, load the master balls (x18)
str     r1,[r0,#0x0]        ;@ and store it into the 1st bag slot
ldr     r1,ultra_ball       ;@ load the ultra balls (x30)
str     r1,[r0,#0x4]        ;@ and store it into the 2nd bag slot
ldr     r1,great_ball       ;@ load the great balls (x30)
str     r1,[r0,#0x8]        ;@ and store it into the 3rd bag slot
check_select:               ;@ check_select label
tst     r5,#0x4             ;@ has Select been pressed / held?
bxne    lr                  ;@ if not, exit
ldrb    r1,[r0,#0x0]        ;@ r1 = bag slot 1 item
ldrb    r2,[r0,#0x4]        ;@ r2 = bag slot 2 item
ldrb    r3,[r0,#0x8]        ;@ r3 = bag slot 3 item
cmp     r1,#0x1             ;@ check if there's a master ball in bag slot 1
bxne    lr                  ;@ if not, exit
cmp     r2,#0x2             ;@ check if there's an ultra ball in bag slot 2
bxne    lr                  ;@ if not, exit
cmp     r3,#0x3             ;@ check if there's a great ball in bag slot 3
bxne    lr                  ;@ if not, exit
ldrh    r1,[r0,#0x2]        ;@ r1 = bag slot 1 quantity
ldrh    r2,[r0,#0x6]        ;@ r2 = bag slot 2 quantity
ldrh    r3,[r0,#0xA]        ;@ r3 = bag slot 3 quantity
cmp     r1,#0x12            ;@ do we have more than 18 master balls?
bxgt    lr                  ;@ if so, exit
cmp     r2,#0x1E            ;@ do we have more that 30 ultra balls?
bxgt    lr                  ;@ if so, exit
cmp     r3,#0x1E            ;@ do we have more than 30 great balls?
bxgt    lr                  ;@ if so, exit
cmp     r2,r3               ;@ is the starting slot number > ending slot number
bxgt    lr                  ;@ if so, exit
sub     r0,r0,#0x18000      ;@ r0 -= 0x18000 (subtract to get the first pc box slot)
mov     r5,#0x1000          ;@ r5 = 0x1000 (pc box offset)
mla     r0,r1,r5,r0         ;@ r0 = (r1 * r5) + (r0) = (pc box * pc box offset) + (base)
sub     r0,r0,r5            ;@ r0 -= r5 (now we have the correct pc box based on the amount of master balls we have)
mov     r5,#0x88            ;@ r5 = 0x88 (pc box slot offset)
mla     r3,r5,r3,r0         ;@ r3 = (r5 * r3) + (r0) = (pc box slot offset * ending slot) + (base)
mla     r2,r5,r2,r0         ;@ r2 = (r5 * r2) + (r0) = (pc box slot offset * starting slot) + (base)
sub     r2,r2,r5            ;@ r2 -= r5 (now we have the correct starting slot based on the amount of ultra balls we have)
mov     r0,#0x0             ;@ r0 = 0x0 (no data / no pokémon)
loop:                       ;@ loop label
cmp     r2,r3               ;@ are we at the end (ending slot) ?
strne   r0,[r2],#0x4        ;@ if not, start removing the pokémon
bne     loop                ;@ and loop again
nop                         ;@ a random nop to get rid of the whitespace at the end of the code (00000000)
bx      lr                  ;@ return

pointer:
.word 0x02000024
bag_slot:
.word 0x00018D20
io_keys:
.word 0x04000130
master_ball:
.word 0x00120001
ultra_ball:
.word 0x001E0002
great_ball:
.word 0x001E0003