# Real Time PC Box Deletion

## Contributers

Special thanks to the following contributer(s):
 
 * [Codr and PokeGen](http://projectpokemon.org/forums/member.php?14421-Codr)

## Compatibility

 * Pokemon: Black 2 (J)

 * Pokemon: White 2 (J)

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
	E0000000 000000E8
	E59F00C8 E5900000
	E3500000 012FFF1E
	E59F10BC E0800001
	E59F50B8 E1D550B0
	E3150C03 1A000005
	E59F10AC E5801000
	E59F10A8 E5801004
	E59F10A4 E5801008
	E3150004 112FFF1E
	E5D01000 E5D02004
	E5D03008 E3510001
	112FFF1E E3520002
	112FFF1E E3530003
	112FFF1E E1D010B2
	E1D020B6 E1D030BA
	E3510012 C12FFF1E
	E352001E C12FFF1E
	E353001E C12FFF1E
	E1520003 C12FFF1E
	E2400906 E3A05A01
	E0200591 E0400005
	E3A05088 E0230395
	E0220295 E0422005
	E3A00000 E1520003
	14820004 1AFFFFFC
	E1A00000 E12FFF1E
	02000024 00018D20
	04000130 00120001
	001E0002 001E0003
	023FE074 E3520003