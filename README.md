# K's Realistic Farming
![My cabbages!!!](https://i.imgur.com/KmLF0Y7.png)

Not being able to get enough seeds to expand my farms pushed me to make a simple content mod which allows to choose between getting food or seeds.

## Overview

This mod changes the crops' growth stages and the amounts of seeds and food dropped on harvest, and adds a way to replant grains and legumes.

### Vegetables

*   All vegetables get an additional growth stage (and a slightly longer growth time to compensate)
*   Vegetables have only a small chance to drop a seed when they're in the mature growth stage (second to last stage)
*   At the last stage vegetables will be flowering and harvesting them will yeld double the seeds that the crop would yeld in vanilla, plus an amount of rot equal to the amount of vegetables they usually drop when mature

### Legumes and grains

*   All legumes and grains don't drop seeds
*   When harvested in the mature growth stage the crops will yeld a double amount of grains/legumes to compensate
*   When harvested in the second to last growth stage the crops will yeld the usual amount of grains/legumes
*   Additionally, there's a small chance for crops to drop a smaller amount of grains/legumes when harvested in the third to last growth stage
*   It will be possible to craft a seed packet using about half of the crop's harvest

### Exceptions

*   Pumpkins work differently so I left them alone
*   I didn't even want to think about how to deal with pineapples

## Examples

### Cabbages

#### General information
|     | **Vanilla** | **Realistic farming** |
| --- | --- | --- |
| Total growth stages | 12  | 13  |
| Mature stage | 12  | 12  |
| Flowering stage | \-  | 13  |
| Maturation time at ~100% growth speed | 1.5 months | 1.6 months |
| Seeds craftable with | \-  | \-  |

#### Yelds on harvest
| **Growth stage** | **Vanilla/seed** | **Realistic farming/seed** | **Vanilla/other** | **Realistic farming/other** |
| --- | --- | --- | --- | --- |
| 11 (almost mature) | almost always 1 | 0   | often 1 cabbage | often 1 cabbage |
| 12 (mature) | at least 1 and rarely 2 | rarely 1 | 2 cabbages | 2 cabbages |
| 13 (flowering) | \-  | at least 2 and rarely 3 | \-  | 2 rot |

### Rice


#### General information
|     | **Vanilla** | **Realistic farming** |
| --- | --- | --- |
| Growth stages | 10  | 10  |
| Mature stage | 10  | 10  |
| Flowering stage | \-  | \-  |
| Maturation time at ~100% growth speed | 2.25 months | 2.25 months |
| Seeds craftable with | \-  | 11 rice |

#### Yelds on harvest
| **Growth stage** | **Vanilla/seed** | **Realistic farming/seed** | **Vanilla/other** | **Realistic farming/other** |
| --- | --- | --- | --- | --- |
| 11 (almost mature) | 0   | 0   | 0 rice | 11-15 rice |
| 12 (mature) | at least 1 and rarely 2 | 0   | 11-15 rice | 22-30 rice |

## Features

*   new seed recipes for all the grains and legumes
*   cool new textures for the flowering vegetables (they change with the seasons!)
*   more rot for your composting needs!
*   let some of your vegetables flower or you might run out of seeds
*   expand your farms easily by starving yourself!
*   bees and butterflies will feed on the vegetables only when they're flowering
*   easily change the mod to your liking simply editing the json patches

Special thanks to Trini for the awesome title image!

Compatibility

*   I didn't test it with any other farming mods so let me know
*   Probably compatible with [XSkills](https://mods.vintagestory.at/show/mod/247) but additional testing is required

Roadmap

1.  possible rebalancing so that crops yeld also 2x the vanilla food amount
2.  add wilted vegetables that can't be eaten but can be used to feed animals or to make rot (like dry fruit mash) and get dropped in place of rot when the flowering plant is harvested 
3.  add a seeding stage after the flowering stage
4.  make flowering cassava as big as the mature plant
5.  make flowering cabbage as big as the mature plants
6.  add the "break to harvest" tooltip on the second to last growth stage for vegetables (might need to convert to a code mod)
7.  translations
