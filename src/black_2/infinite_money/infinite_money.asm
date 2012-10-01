ldr r0,money
ldr r1,value
str r1,[r0]
bx lr

money:
.word 0x02226084
value:
.word 0x0098967F