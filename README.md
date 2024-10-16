# TXBeditor
<p align="center">
  <img src="TXBeditor.png" />
</p>

A program to edit TXB texture containers found in [GioGio's Bizarre Adventure](https://jojowiki.com/GioGio%27s_Bizarre_Adventure), probably works with Auto Modellista too.
You can freely add or remove textures and modify their order and Load IDs.

## Load IDs
When the game loads textures from TXB files, it checks if there is already a texture with an identical ID already loaded in memory, and if so, discards the duplicate and references the previously loaded texture.<br><br>
This causes a problem for modding, since you would need to edit every instance of a texture on each file (For example, a player file and all it's actor dependencies for each 3D cutscene). So you can sorta circumvent conflicts by changing the Load IDs to something bigger.

## Rainbow ImgLib
Viewing and editing of the internal TIM2 files is thanks to the image library from [Rainbow by Marco Calautti](https://github.com/marco-calautti/Rainbow).<br>
The Palette construction method is modified so that the number of palettes is always 1. Neither game ever uses the second palette on textures despite being present on all 128 byte aligned TIM2s, so the multi-clut workflow just gets in the way of editing the textures normally. The use of XML files for import/export is also gone, so the user only deals with PNG files instead.

## Icon Set
The icons used on the interface are from the [famfamfam Silk Icon pack](https://github.com/legacy-icons/famfamfam-silk), licensed under the Creative Commons Attribution 2.5 License.

## AFSLib
To load .txb files from AFS archives, [AFSLib](https://github.com/MaikelChan/AFSLib/tree/main) is used, which is licensed under the [MIT license](https://github.com/penguino118/PZZ-ARC/Tools/AFSLib/blob/main/AFSLib/LICENSE).
