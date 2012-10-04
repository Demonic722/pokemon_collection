# Real Time PC Box Deletion

## Contributers

Special thanks to the following contributer(s):
 
 * [Codr and PokeGen](http://projectpokemon.org/forums/member.php?14421-Codr)

## Compatibility

 * Pokemon: HeartGold (U) [IPKE 4DFFBF91]
 * Pokemon: SoulSilver (U) [IPGE 2D5118CA]

## Usage

Press L+R to receive 18 Master Balls, 30 Ultra Balls and 30 Great Balls.

 * Master Balls - PC Box
 * Ultra Balls - Starting Slot
 * Great Balls - Ending Slot

Press Select to remove those Pokémon from that PC Box's Slot(s).

### Examples

 * If the user discards 17 master balls, 29 Ultra Balls and 24 Great Balls,
   Pokémon 1-6 in Box 1 will be "released".

## Code

    023FE074 012FFF11
    E0000000 00000098
    E28F0001 E12FFF10
    6800481C D0342800
    880BA11B 4D1C18C0
    882A884B D105421A
    60044C1A 60444C1A
    60844C1A 421A888B
    7802D123 7A047903
    D11E2A01 D11C2B02
    D11A2C03 88C38842
    2A128944 2B1EDC15
    2C1EDC13 88CDDC11
    25101940 436A022D
    18801B52 436B2588
    1B5B436C 1824181B
    601A2200 42A33304
    4770D1FB 02111880
    03000D14 E9FC0004
    04000130 00120001
    001E0002 001E0003
    023FE074 E3520003