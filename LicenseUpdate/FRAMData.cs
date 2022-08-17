﻿

namespace UpdateFRAMBlocks
{
    class FRAMData
    {
        public static string m_Framdata = "CHECK,0,2,0A0A,Validation of file values,0|"
+ "LENGTH,2,2,1422,,0|"
+ "BLOCK_START,4,2,0A0A,,0|"
+ "BLOCK_ID,6,1,0,Block ID 0: System Details,0|"
+ "FRAM_REV,7,1,9,FRAM Rev,0|"
+ "SYSTEM_SERIAL_NUMBER,8,2,240,Serial Number of System,0|"
+ "IDN,10,50,GRL-USB-PD-C2,Product ID,1|"
+ "SOM_BOARD_NUMBER,60,2,258,Serial Numebr of SOM board,0|"
+ "SOM_BOARD_REV,62,1,5,SOM Board Revision (1 or 2),0|"
+ "BASE_BOARD_NUMBER,63,2,240,Serial Numebr of Base Board,0|"
+ "BASE_BOARD_REV,65,1,6,Revision Number of Base Board,0|"
+ "ELOAD_NUMBER,66,2,310,Serial Number of E-Load,0|"
+ "ELOAD_REV,68,1,2,E-Load Revision,0|"
+ "NOISE_NUMBER,69,2,168,Serial Number of Noise Board,0|"
+ "NOISE_REV,71,1,2,Revision Number of Noise Board,0|"
+ "LICENSE,72,2,32637,License,0|"
+ "Usage,74,2,17,License Repeat for verification,0|"
+ "DILIMTER,76,1,;,,1|"
+ "BLOCK_START,77,2,0A0A,,0|"
+ "BLOCK_ID,79,1,1,Block ID 1: Manufacturing Details,0|"
+ "Manufacturing_month,80,1,3,Manufacturing Month in Number,0|"
+ "Manufacturing_year,81,2,2022,Manufacturing Year in Number,0|"
+ "Location_of_Manufacturing,83,1,2,Location of Manufacturing ; 1 = BANGALORE / 2 = Taiwan / 3= USA,0|"
+ "DILIMTER,84,1,;,,1|"
+ "BLOCK_START,85,2,0A0A,,0|"
+ "BLOCK_ID,87,1,2,Block 2: Calibration Details,0|"
+ "Calibration_Date,88,1,24,Day of Calibration,0|"
+ "Calibration_Month,89,1,7,Month of Calibration,0|"
+ "Calibration_Year,90,2,2019,Year of Calibration,0|"
+ "Next_Calibration_Date,92,1,23,Next Calibration Date,0|"
+ "Next_Calibration_Month,93,1,7,Next Calibration Month,0|"
+ "Next_Calibration_Year,94,2,2020,Next Calibration Year,0|"
+ "NAME,96,20,mwu,Calibrated Person,1|"
+ "DILIMTER,116,1,;,,1|"
+ "BLOCK_START,117,2,0A0A,,0|"
+ "BLOCK_ID,119,1,3,Block 3: ADC BANK 1 Calibration,0|"
+ "ADC_BANK,120,1,1,ADC Bank 1,0|"
+ "ADC_NO,121,1,0,VBUS Current -ADC 0 of Bank 1,0|"
+ "ADC_UNIT,122,1,A,Unit is AMP,1|"
+ "CURRENT1,123,2,0,CURRENT IN 10 mA STEPS,0|"
+ "ADC_COUNT,125,2,2267,,0|"
+ "CURRENT2,127,2,100,1A,0|"
+ "ADC_COUNT,129,2,1987,,0|"
+ "CURRENT3,131,2,300,3A,0|"
+ "ADC_COUNT,133,2,1433,,0|"
+ "CURRENT4,135,2,500,5A,0|"
+ "ADC_COUNT,137,2,877,,0|"
+ "CURRENT5,139,2,600,6A,0|"
+ "ADC_COUNT,141,2,599,,0|"
+ "DILIMTER,143,1,;,,1|"
+ "ADC_BANK,144,1,1,ADC Bank 1,0|"
+ "ADC_NO,145,1,1,CC2 Current,0|"
+ "ADC_UNIT,146,1,A,Unit is AMP,1|"
+ "CURRENT1,147,2,0,CURRENT IN 10mA STEPS,0|"
+ "ADC_COUNT,149,2,2269,,0|"
+ "CURRENT2,151,2,25,250mA,0|"
+ "ADC_COUNT,153,2,2131,,0|"
+ "CURRENT3,155,2,50,500mA,0|"
+ "ADC_COUNT,157,2,1993,,0|"
+ "CURRENT4,159,2,100,1000A,0|"
+ "ADC_COUNT,161,2,1718,,0|"
+ "CURRENT5,163,2,150,1.5A,0|"
+ "ADC_COUNT,165,2,1441,,0|"
+ "DILIMTER,167,1,;,,1|"
+ "ADC_BANK,168,1,1,ADC Bank 1,0|"
+ "ADC_NO,169,1,2,CC1 Current,0|"
+ "ADC_UNIT,170,1,A,Unit is AMP,1|"
+ "CURRENT1,171,2,0,CURRENT IN 10 mA STEPS,0|"
+ "ADC_COUNT,173,2,2269,,0|"
+ "CURRENT2,175,2,25,250mA,0|"
+ "ADC_COUNT,177,2,2132,,0|"
+ "CURRENT3,179,2,50,500mA,0|"
+ "ADC_COUNT,181,2,1994,,0|"
+ "CURRENT4,183,2,100,1000A,0|"
+ "ADC_COUNT,185,2,1718,,0|"
+ "CURRENT5,187,2,150,1.5A,0|"
+ "ADC_COUNT,189,2,1441,,0|"
+ "DILIMTER,191,1,;,,1|"
+ "ADC_BANK,192,1,1,ADC Bank 1,0|"
+ "ADC_NO,193,1,3,VBUS VOLTAGE,0|"
+ "ADC_UNIT,194,1,V,Unit in VOLTAGE,1|"
+ "VOLTAGE1,195,2,10,Voltage in 100mV Steps,0|"
+ "ADC_COUNT,197,2,489,,0|"
+ "VOLTAGE2,199,2,50,5V,0|"
+ "ADC_COUNT,201,2,1023,,0|"
+ "VOLTAGE3,203,2,100,10V,0|"
+ "ADC_COUNT,205,2,1693,,0|"
+ "VOLTAGE4,207,2,150,15V,0|"
+ "ADC_COUNT,209,2,2363,,0|"
+ "VOLTAGE5,211,2,200,20V,0|"
+ "ADC_COUNT,213,2,3033,,0|"
+ "DILIMTER,215,1,;,,1|"
+ "ADC_BANK,216,1,1,ADC Bank 1,0|"
+ "ADC_NO,217,1,4,CC2 VOLTAGE,0|"
+ "ADC_UNIT,218,1,V,Unit in VOLTAGE,1|"
+ "VOLTAGE1,219,2,0,Voltage in 100mV Steps,0|"
+ "ADC_COUNT,221,2,0,,0|"
+ "VOLTAGE2,223,2,5,500mV,0|"
+ "ADC_COUNT,225,2,274,,0|"
+ "VOLTAGE3,227,2,25,2500mV,0|"
+ "ADC_COUNT,229,2,1380,,0|"
+ "VOLTAGE4,231,2,35,3500mV,0|"
+ "ADC_COUNT,233,2,1933,,0|"
+ "VOLTAGE5,235,2,50,5000mV,0|"
+ "ADC_COUNT,237,2,2762,,0|"
+ "DILIMTER,239,1,;,,1|"
+ "ADC_BANK,240,1,1,ADC Bank 1,0|"
+ "ADC_NO,241,1,5,CC1 VOLTAGE,0|"
+ "ADC_UNIT,242,1,V,Unit in VOLTAGE,1|"
+ "VOLTAGE1,243,2,0,Voltage in 100mV Steps,0|"
+ "ADC_COUNT,245,2,0,,0|"
+ "VOLTAGE2,247,2,5,500mV,0|"
+ "ADC_COUNT,249,2,274,,0|"
+ "VOLTAGE3,251,2,25,2500mV,0|"
+ "ADC_COUNT,253,2,1380,,0|"
+ "VOLTAGE4,255,2,35,3500mV,0|"
+ "ADC_COUNT,257,2,1933,,0|"
+ "VOLTAGE5,259,2,50,5000mV,0|"
+ "ADC_COUNT,261,2,2749,,0|"
+ "DILIMTER,263,1,;,,1|"
+ "ADC_BANK,264,1,1,ADC Bank 2,0|"
+ "ADC_NO,265,1,30,REFERENCE VOLTAGE,0|"
+ "ADC_UNIT,266,1,V,Unit in VOLTAGE,1|"
+ "VOLTAGE1,267,2,25,2500mV,0|"
+ "ADC_COUNT,269,2,0,,0|"
+ "VOLTAGE2,271,2,1,NA,0|"
+ "ADC_COUNT,273,2,0,,0|"
+ "VOLTAGE3,275,2,2,NA,0|"
+ "ADC_COUNT,277,2,0,,0|"
+ "VOLTAGE4,279,2,3,NA,0|"
+ "ADC_COUNT,281,2,0,,0|"
+ "VOLTAGE5,283,2,4,NA,0|"
+ "ADC_COUNT,285,2,0,,0|"
+ "DILIMTER,287,1,;,,1|"
+ "BLOCK_START,288,2,0A0A,,0|"
+ "BLOCK_ID,290,1,4,Block 4: ADC BANK 2 Calibration,0|"
+ "ADC_BANK,291,1,2,ADC Bank 2,0|"
+ "ADC_NO,292,1,9,VBUS Current -ADC 0 of Bank 1,0|"
+ "ADC_UNIT,293,1,A,Unit is AMP,1|"
+ "CURRENT1,294,2,0,CURRENT IN 10 mA STEPS,0|"
+ "ADC_COUNT,296,2,2268,,0|"
+ "CURRENT2,298,2,100,1A,0|"
+ "ADC_COUNT,300,2,1990,,0|"
+ "CURRENT3,302,2,300,3A,0|"
+ "ADC_COUNT,304,2,1437,,0|"
+ "CURRENT4,306,2,500,5A,0|"
+ "ADC_COUNT,308,2,877,,0|"
+ "CURRENT5,310,2,600,6A,0|"
+ "ADC_COUNT,312,2,599,,0|"
+ "DILIMTER,314,1,;,,1|"
+ "ADC_BANK,315,1,2,ADC Bank 2,0|"
+ "ADC_NO,316,1,10,CC2 Current,0|"
+ "ADC_UNIT,317,1,A,Unit is AMP,1|"
+ "CURRENT1,318,2,0,CURRENT IN 10 mA STEPS,0|"
+ "ADC_COUNT,320,2,2267,,0|"
+ "CURRENT2,322,2,25,250mA,0|"
+ "ADC_COUNT,324,2,2129,,0|"
+ "CURRENT3,326,2,50,500mA,0|"
+ "ADC_COUNT,328,2,1991,,0|"
+ "CURRENT4,330,2,100,1000A,0|"
+ "ADC_COUNT,332,2,1716,,0|"
+ "CURRENT5,334,2,150,1.5A,0|"
+ "ADC_COUNT,336,2,1439,,0|"
+ "DILIMTER,338,1,;,,1|"
+ "ADC_BANK,339,1,2,ADC Bank 2,0|"
+ "ADC_NO,340,1,11,CC1 Current,0|"
+ "ADC_UNIT,341,1,A,Unit is AMP,1|"
+ "CURRENT1,342,2,0,CURRENT IN 10 mA STEPS,0|"
+ "ADC_COUNT,344,2,2269,,0|"
+ "CURRENT2,346,2,25,250mA,0|"
+ "ADC_COUNT,348,2,2131,,0|"
+ "CURRENT3,350,2,50,500mA,0|"
+ "ADC_COUNT,352,2,1993,,0|"
+ "CURRENT4,354,2,100,1000A,0|"
+ "ADC_COUNT,356,2,1718,,0|"
+ "CURRENT5,358,2,150,1.5A,0|"
+ "ADC_COUNT,360,2,1442,,0|"
+ "DILIMTER,362,1,;,,1|"
+ "ADC_BANK,363,1,2,ADC Bank 2,0|"
+ "ADC_NO,364,1,12,VBUS VOLTAGE,0|"
+ "ADC_UNIT,365,1,V,Unit in VOLTAGE,1|"
+ "VOLTAGE1,366,2,10,Voltage in 100mV Steps,0|"
+ "ADC_COUNT,368,2,488,,0|"
+ "VOLTAGE2,370,2,50,5V,0|"
+ "ADC_COUNT,372,2,1021,,0|"
+ "VOLTAGE3,374,2,100,10V,0|"
+ "ADC_COUNT,376,2,1690,,0|"
+ "VOLTAGE4,378,2,150,15V,0|"
+ "ADC_COUNT,380,2,2359,,0|"
+ "VOLTAGE5,382,2,200,20V,0|"
+ "ADC_COUNT,384,2,3027,,0|"
+ "DILIMTER,386,1,;,,1|"
+ "ADC_BANK,387,1,2,ADC Bank 2,0|"
+ "ADC_NO,388,1,13,CC2 VOLTAGE,0|"
+ "ADC_UNIT,389,1,V,Unit in VOLTAGE,1|"
+ "VOLTAGE1,390,2,0,Voltage in 100mV Steps,0|"
+ "ADC_COUNT,392,2,0,,0|"
+ "VOLTAGE2,394,2,5,500mV,0|"
+ "ADC_COUNT,396,2,274,,0|"
+ "VOLTAGE3,398,2,25,2500mV,0|"
+ "ADC_COUNT,400,2,1380,,0|"
+ "VOLTAGE4,402,2,35,3500mV,0|"
+ "ADC_COUNT,404,2,1933,,0|"
+ "VOLTAGE5,406,2,50,5000mV,0|"
+ "ADC_COUNT,408,2,2762,,0|"
+ "DILIMTER,410,1,;,,1|"
+ "ADC_BANK,411,1,2,ADC Bank 2,0|"
+ "ADC_NO,412,1,14,CC1 VOLTAGE,0|"
+ "ADC_UNIT,413,1,V,Unit in VOLTAGE,1|"
+ "VOLTAGE1,414,2,0,Voltage in 100mV Steps,0|"
+ "ADC_COUNT,416,2,0,,0|"
+ "VOLTAGE2,418,2,5,500mV,0|"
+ "ADC_COUNT,420,2,274,,0|"
+ "VOLTAGE3,422,2,25,2500mV,0|"
+ "ADC_COUNT,424,2,1380,,0|"
+ "VOLTAGE4,426,2,35,3500mV,0|"
+ "ADC_COUNT,428,2,1933,,0|"
+ "VOLTAGE5,430,2,50,5000mV,0|"
+ "ADC_COUNT,432,2,2763,,0|"
+ "DILIMTER,434,1,;,,1|"
+ "ADC_BANK,435,1,2,ADC Bank 1,0|"
+ "ADC_NO,436,1,15,Type-C Functional Port1 all lines except CC/VBUS,0|"
+ "ADC_UNIT,437,1,V,Unit in VOLTAGE,1|"
+ "VOLTAGE1,438,2,25,25mV,0|"
+ "ADC_COUNT,440,2,130,,0|"
+ "VOLTAGE2,442,2,50,500mV,0|"
+ "ADC_COUNT,444,2,264,,0|"
+ "VOLTAGE3,446,2,100,1000mV,0|"
+ "ADC_COUNT,448,2,534,,0|"
+ "VOLTAGE4,450,2,200,2000mV,0|"
+ "ADC_COUNT,452,2,1072,,0|"
+ "VOLTAGE5,454,2,300,3000mV,0|"
+ "ADC_COUNT,456,2,1609,,0|"
+ "DILIMTER,458,1,;,,1|"
+ "BLOCK_START,459,2,0A0A,,0|"
+ "BLOCK_ID,461,1,5,Block 5: ADC BANK 3 Calibration,0|"
+ "ADC_BANK,462,1,3,ADC Bank 3,0|"
+ "ADC_NO,463,1,32,VBUS Current -ADC 0 of Bank 1,0|"
+ "ADC_UNIT,464,1,V,Not Connected,1|"
+ "CURRENT1,465,2,50,5V Current,0|"
+ "ADC_COUNT,467,2,2,,0|"
+ "CURRENT2,469,2,90,9V Current,0|"
+ "ADC_COUNT,471,2,4,,0|"
+ "CURRENT3,473,2,120,12V Current,0|"
+ "ADC_COUNT,475,2,6,,0|"
+ "CURRENT4,477,2,150,15V Current,0|"
+ "ADC_COUNT,479,2,8,,0|"
+ "CURRENT5,481,2,200,20V Current,0|"
+ "ADC_COUNT,483,2,10,,0|"
+ "DILIMTER,485,1,;,,1|"
+ "ADC_BANK,486,1,3,ADC Bank 3,0|"
+ "ADC_NO,487,1,33,Not Connected,0|"
+ "ADC_UNIT,488,1,A,Not Connected,1|"
+ "CURRENT1,489,2,1,NA,0|"
+ "ADC_COUNT,491,2,2,NA,0|"
+ "CURRENT2,493,2,3,NA,0|"
+ "ADC_COUNT,495,2,4,NA,0|"
+ "CURRENT3,497,2,5,NA,0|"
+ "ADC_COUNT,499,2,6,NA,0|"
+ "CURRENT4,501,2,7,NA,0|"
+ "ADC_COUNT,503,2,8,NA,0|"
+ "CURRENT5,505,2,9,NA,0|"
+ "ADC_COUNT,507,2,10,NA,0|"
+ "DILIMTER,509,1,;,,1|"
+ "ADC_BANK,510,1,3,ADC Bank 3,0|"
+ "ADC_NO,511,1,8,Dplus Current,0|"
+ "ADC_UNIT,512,1,A,Current in Amps,1|"
+ "CURRENT1,513,2,0,CURRENT IN 10 mA STEPS,0|"
+ "ADC_COUNT,515,2,1,,0|"
+ "CURRENT2,517,2,1,1mA,0|"
+ "ADC_COUNT,519,2,809,,0|"
+ "CURRENT3,521,2,2,2mA,0|"
+ "ADC_COUNT,523,2,1616,,0|"
+ "CURRENT4,525,2,3,3mA,0|"
+ "ADC_COUNT,527,2,2424,,0|"
+ "CURRENT5,529,2,4,4mA,0|"
+ "ADC_COUNT,531,2,3231,,0|"
+ "DILIMTER,533,1,;,,1|"
+ "ADC_BANK,534,1,3,ADC Bank 3,0|"
+ "ADC_NO,535,1,7,D Minus Voltage,0|"
+ "ADC_UNIT,536,1,V,Unit in VOLTAGE,1|"
+ "VOLTAGE1,537,2,0,Voltage in 100mV Steps,0|"
+ "ADC_COUNT,539,2,1,,0|"
+ "VOLTAGE2,541,2,5,500 mV,0|"
+ "ADC_COUNT,543,2,407,,0|"
+ "VOLTAGE3,545,2,10,1000mV,0|"
+ "ADC_COUNT,547,2,815,,0|"
+ "VOLTAGE4,549,2,20,2000mV,0|"
+ "ADC_COUNT,551,2,1637,,0|"
+ "VOLTAGE5,553,2,30,3000mA,0|"
+ "ADC_COUNT,555,2,2450,,0|"
+ "DILIMTER,557,1,;,,1|"
+ "ADC_BANK,558,1,3,ADC Bank 3,0|"
+ "ADC_NO,559,1,6,D Plus Voltage,0|"
+ "ADC_UNIT,560,1,V,Unit in VOLTAGE,1|"
+ "VOLTAGE1,561,2,0,Voltage in 100mV Steps,0|"
+ "ADC_COUNT,563,2,0,,0|"
+ "VOLTAGE2,565,2,5,500 mV,0|"
+ "ADC_COUNT,567,2,404,,0|"
+ "VOLTAGE3,569,2,10,1000mV,0|"
+ "ADC_COUNT,571,2,812,,0|"
+ "VOLTAGE4,573,2,20,2000mV,0|"
+ "ADC_COUNT,575,2,1638,,0|"
+ "VOLTAGE5,577,2,30,3000mA,0|"
+ "ADC_COUNT,579,2,2450,,0|"
+ "DILIMTER,581,1,;,,1|"
+ "ADC_BANK,582,1,3,ADC Bank 2,0|"
+ "ADC_NO,583,1,18,Extension Connetor,0|"
+ "ADC_UNIT,584,1,V,Unit in VOLTAGE,1|"
+ "VOLTAGE1,585,2,0,Voltage in 100mV Steps,0|"
+ "ADC_COUNT,587,2,29,,0|"
+ "VOLTAGE2,589,2,5,500mV,0|"
+ "ADC_COUNT,591,2,82,,0|"
+ "VOLTAGE3,593,2,25,2500mV,0|"
+ "ADC_COUNT,595,2,372,,0|"
+ "VOLTAGE4,597,2,35,3500mV,0|"
+ "ADC_COUNT,599,2,523,,0|"
+ "VOLTAGE5,601,2,50,5000mV,0|"
+ "ADC_COUNT,603,2,744,,0|"
+ "DILIMTER,605,1,;,,1|"
+ "ADC_BANK,606,1,3,ADC Bank 2,0|"
+ "ADC_NO,607,1,38,Not Connected,0|"
+ "ADC_UNIT,608,1,A,Not Connected,1|"
+ "VOLTAGE1,609,2,1,NA,0|"
+ "ADC_COUNT,611,2,2,NA,0|"
+ "VOLTAGE2,613,2,3,NA,0|"
+ "ADC_COUNT,615,2,4,NA,0|"
+ "VOLTAGE3,617,2,5,NA,0|"
+ "ADC_COUNT,619,2,6,NA,0|"
+ "VOLTAGE4,621,2,7,NA,0|"
+ "ADC_COUNT,623,2,8,NA,0|"
+ "VOLTAGE5,625,2,9,NA,0|"
+ "ADC_COUNT,627,2,10,NA,0|"
+ "DILIMTER,629,1,;,,1|"
+ "BLOCK_START,630,2,0A0A,,0|"
+ "BLOCK_ID,632,1,6,Block 6: High SpeedADC,0|"
+ "ADC_BANK,633,1,4,ADC Bank 4,0|"
+ "ADC_NO,634,1,40,Port1 HS ADC CC Line,0|"
+ "ADC_UNIT,635,1,V,Unit in VOLTAGE,1|"
+ "VOLTAGE1,636,2,0,Voltage in 100mV Steps,0|"
+ "ADC_COUNT,638,2,2264,,0|"
+ "VOLTAGE2,640,2,5,500mV,0|"
+ "ADC_COUNT,642,2,1999,,0|"
+ "VOLTAGE3,644,2,10,1000mV,0|"
+ "ADC_COUNT,646,2,1733,,0|"
+ "VOLTAGE4,648,2,15,1500mV,0|"
+ "ADC_COUNT,650,2,1465,,0|"
+ "VOLTAGE5,652,2,40,4000mV,0|"
+ "ADC_COUNT,654,2,129,,0|"
+ "DILIMTER,656,1,;,,1|"
+ "ADC_BANK,657,1,4,ADC Bank 4,0|"
+ "ADC_NO,658,1,41,Port2 HS ADC CC Line,0|"
+ "ADC_UNIT,659,1,V,Unit in VOLTAGE,1|"
+ "VOLTAGE1,660,2,0,Voltage in 100mV Steps,0|"
+ "ADC_COUNT,662,2,2250,,0|"
+ "VOLTAGE2,664,2,5,500mV,0|"
+ "ADC_COUNT,666,2,1987,,0|"
+ "VOLTAGE3,668,2,10,1000mV,0|"
+ "ADC_COUNT,670,2,1725,,0|"
+ "VOLTAGE4,672,2,15,1500mV,0|"
+ "ADC_COUNT,674,2,1462,,0|"
+ "VOLTAGE5,676,2,40,4000mV,0|"
+ "ADC_COUNT,678,2,149,,0|"
+ "DILIMTER,680,1,;,,1|"
+ "BLOCK_START,681,2,0A0A,,0|"
+ "BLOCK_ID,683,1,7,Block 7: Eload Calibration,0|"
+ "ELOAD_NO,684,1,1,Eload1 - Port A VBUS,0|"
+ "UNIT,685,1,A,Current in Amps,1|"
+ "CURRENT1,686,2,100,1A load,0|"
+ "DAC_COUNT,688,2,38,,0|"
+ "CURRENT2,690,2,200,2A,0|"
+ "DAC_COUNT,692,2,77,,0|"
+ "CURRENT3,694,2,300,3A,0|"
+ "DAC _COUNT,696,2,117,,0|"
+ "CURRENT4,698,2,400,4A,0|"
+ "DAC_COUNT,700,2,157,,0|"
+ "CURRENT5,702,2,500,5A,0|"
+ "DAC_COUNT,704,2,198,,0|"
+ "DILIMTER,706,1,;,,1|"
+ "ELOAD_NO,707,1,2,Eload2 - Port A VCONN,0|"
+ "UNIT,708,1,A,Current in 10 Amps,1|"
+ "CURRENT1,709,2,25,250mA,0|"
+ "DAC_COUNT,711,2,23,,0|"
+ "CURRENT2,713,2,50,500mA,0|"
+ "DAC_COUNT,715,2,48,,0|"
+ "CURRENT3,717,2,100,1A load,0|"
+ "DAC_COUNT,719,2,98,,0|"
+ "CURRENT4,721,2,125,1.25A load,0|"
+ "DAC_COUNT,723,2,124,,0|"
+ "CURRENT5,725,2,150,1.5A load,0|"
+ "DAC_COUNT,727,2,150,,0|"
+ "DILIMTER,729,1,;,,1|"
+ "ELOAD_NO,730,1,3,Eload3 - Port B VBUS,0|"
+ "UNIT,731,1,A,Current in Amps,1|"
+ "CURRENT1,732,2,100,1A load,0|"
+ "DAC_COUNT,734,2,37,,0|"
+ "CURRENT2,736,2,200,2A,0|"
+ "DAC_COUNT,738,2,77,,0|"
+ "CURRENT3,740,2,300,3A,0|"
+ "DAC_COUNT,742,2,118,,0|"
+ "CURRENT4,744,2,400,4A,0|"
+ "DAC_COUNT,746,2,158,,0|"
+ "CURRENT5,748,2,500,5A,0|"
+ "DAC_COUNT,750,2,198,,0|"
+ "DILIMTER,752,1,;,,1|"
+ "ELOAD_NO,753,1,4,Eload4 - Port B VCONN,0|"
+ "UNIT,754,1,A,Current in Amps,1|"
+ "CURRENT1,755,2,25,250mA,0|"
+ "DAC_COUNT,757,2,22,,0|"
+ "CURRENT2,759,2,50,500mA,0|"
+ "DAC_COUNT,761,2,47,,0|"
+ "CURRENT3,763,2,100,1A load,0|"
+ "DAC_COUNT,765,2,97,,0|"
+ "CURRENT4,767,2,125,1.25A load,0|"
+ "DAC_COUNT,769,2,123,,0|"
+ "CURRENT5,771,2,150,1.5A load,0|"
+ "DAC_COUNT,773,2,148,,0|"
+ "DILIMTER,775,1,;,,1|"
+ "BLOCK_START,776,2,0A0A,Block Start,0|"
+ "BLOCK_ID,778,1,8,Block 8: PPS Calibration,0|"
+ "PPS_NO,779,1,1,VBUS - PORT A,0|"
+ "ADC_UNIT,780,1,V,Unit in VOLTAGE,1|"
+ "VOLTAGE1,781,2,10,PPS DEFAULT CALIBRATION,0|"
+ "DAC_COUNT,783,2,4519,,0|"
+ "VOLTAGE2,785,2,50,5000mV,0|"
+ "DAC_COUNT,787,2,250,,0|"
+ "VOLTAGE3,789,2,90,9000mV,0|"
+ "DAC_COUNT,791,2,459,,0|"
+ "VOLTAGE4,793,2,150,15000mV,0|"
+ "DAC_COUNT,795,2,768,,0|"
+ "VOLTAGE5,797,2,200,20000mV,0|"
+ "DAC_COUNT,799,2,1031,,0|"
+ "DILIMTER,801,1,;,,1|"
+ "PPS_NO,802,1,2,VCONN - PORT A,0|"
+ "DAC Unit,803,1,V,Unit in VOLTAGE,1|"
+ "VOLTAGE1,804,2,20,2000mV,0|"
+ "DAC_COUNT,806,2,239,,0|"
+ "VOLTAGE2,808,2,30,3000mV,0|"
+ "DAC_COUNT,810,2,213,,0|"
+ "VOLTAGE3,812,2,40,4000mV,0|"
+ "DAC_COUNT,814,2,186,,0|"
+ "VOLTAGE4,816,2,45,4500mV,0|"
+ "DAC_COUNT,818,2,171,,0|"
+ "VOLTAGE5,820,2,50,5000mV,0|"
+ "DAC_COUNT,822,2,157,,0|"
+ "DILIMTER,824,1,;,,1|"
+ "PPS_NO,825,1,3,VBUS - PORT B,0|"
+ "DAC_Unit,826,1,V,Unit in VOLTAGE,1|"
+ "VOLTAGE1,827,2,10,PPS DEFAULT CALIBRATION,0|"
+ "DAC_COUNT,829,2,4561,,0|"
+ "VOLTAGE2,831,2,50,5000mV,0|"
+ "DAC_COUNT,833,2,250,,0|"
+ "VOLTAGE3,835,2,90,9000mV,0|"
+ "DAC_COUNT,837,2,461,,0|"
+ "VOLTAGE4,839,2,150,15000mV,0|"
+ "DAC_COUNT,841,2,771,,0|"
+ "VOLTAGE5,843,2,200,20000mV,0|"
+ "DAC_COUNT,845,2,1034,,0|"
+ "DILIMTER,847,1,;,,1|"
+ "PPS_NO,848,1,4,VCONN - PORT B,0|"
+ "DAC_Unit,849,1,V,Unit in VOLTAGE,1|"
+ "VOLTAGE1,850,2,20,2000mV,0|"
+ "DAC_COUNT,852,2,239,,0|"
+ "VOLTAGE2,854,2,30,3000mV,0|"
+ "DAC_COUNT,856,2,213,,0|"
+ "VOLTAGE3,858,2,40,4000mV,0|"
+ "DAC_COUNT,860,2,186,,0|"
+ "VOLTAGE4,862,2,45,4500mV,0|"
+ "DAC_COUNT,864,2,171,,0|"
+ "VOLTAGE5,866,2,50,5000mV,0|"
+ "DAC_COUNT,868,2,157,,0|"
+ "DILIMTER,870,1,;,,1|"
+ "BLOCK_START,871,2,0A0A,Block Start,0|"
+ "BLOCK_ID,873,1,9,NOISE Calibration,0|"
+ "GROUP1_DAC,874,1,146,DAC 0V [Grp1],0|"
+ "GROUP2_DAC,875,1,173,DAC 250mV [Grp3],0|"
+ "GROUP3_DAC,876,1,116,DAC -250mV [Grp2],0|"
+ "GEN1_NOISE_PK_PK,877,1,66,1.6MHZ noise Pk_Pk,0|"
+ "BISTRISE_TIME,878,1,208,BISTRise Time,0|"
+ "BIST_PK_PK_GRP1,879,1,16,Grp1 ->1.20V,0|"
+ "BIST_PK_PK_GRP2_3,880,1,5,Grp2&3 ->1.04V,0|"
+ "BUSIDLE_DAC,881,1,112,BUSIDLE_DAC,0|"
+ "BUSIDLE_NOISE_PK_PK,882,1,248,BUSIDLE_NOISE_PK_PK,0|"
+ "GEN2_5M_PK_PK,883,1,240,5MHZ PK PK,0|"
+ "GEN2_750K_PK_PK,884,1,80,750KHz PK PK,0|"
+ "BYTE12,885,1,1,,0|"
+ "BYTE13,886,1,153,,0|"
+ "BYTE14,887,1,180,,0|"
+ "BYTE15,888,1,122,,0|"
+ "BYTE16,889,1,1,,0|"
+ "BYTE17,890,1,0,,0|"
+ "BYTE18,891,1,0,,0|"
+ "BYTE19,892,1,27,,0|"
+ "BYTE20,893,1,26,,0|"
+ "DILIMTER,894,1,;,,1|"
+ "BLOCK_START,895,2,0A0A,Block Start,0|"
+ "BLOCK_ID,897,1,10,FUNCTIONAL_CALIBRATION,0|"
+ "DP_0.6,898,1,0,,0|"
+ "DP_3.3,899,1,0,,0|"
+ "DILIMTER,900,1,;,,1|"
+ "DM_0.6,901,1,0,,0|"
+ "DM_3.3,902,1,0,,0|"
+ "DILIMTER,903,1,;,,1|"
+ "50_OHM,904,2,0,Rdcp_dat 0 ohm value,0|"
+ "100_OHM,906,2,0,Rdcp_dat 40 ohm value,0|"
+ "150_OHM,908,2,0,Rdm_dwn Lower bound value for 14.3K,0|"
+ "500K_OHM,910,2,0,Rdm_dwn upper boud value for 24.9K,0|"
+ "1M_OHM,912,2,0,Rdm_dwn Value for Substraction,0|"
+ "1.5M_OHM,914,2,0,Rdat_lkg Lower bound value for 300K,0|"
+ "2M_OHM,916,2,0,Rdat_lkg Upper bound value for 1500K,0|"
+ "2.5M_OHM,918,2,0,Rdat_lkg Middle bound value for 1000K,0|"
+ "DILIMTER,920,1,;,,1|"
+ "BLOCK_START,921,2,0A0A,Block Start,0|"
+ "BLOCK_ID,923,1,11,Temporary_License,0|"
+ "TEMP_LICENSE,924,2,23407,0,0|"
+ "License_Start_Date,926,1,27,Start date of License,0|"
+ "License_Start_Month,927,1,10,Start month of License,0|"
+ "License_Start_Year,928,2,2021,Start year of License,0|"
+ "License_End_Date,930,1,27,End date of License,0|"
+ "License_End_Month,931,1,10,End month of License,0|"
+ "License_End_Year,932,2,2022,End year of License,0|"
+ "License_LastRun_Date,934,1,0,date of last run,0|"
+ "License_LastRun_Month,935,1,0,month of last run,0|"
+ "License_LastRun_Year,936,2,0,year of last run,0|"
+ "Reserved,938,10,0,Reserved,0|"
+ "Reserved,948,10,0,Reserved,0|"
+ "DILIMTER,958,1,;,,1|"
+ "BLOCK_START,959,2,0A0A,Block Start,0|"
+ "BLOCK_ID,961,1,12,C2_Rework_Information,0|"
+ "Base_Board_Rework1,962,1,0,Base Board rework Info,0|"
+ "Base_Board_Rework2,963,1,27,Base Board rework Info,0|"
+ "Base_Board_Rework3,964,1,0,Base Board rework Info,0|"
+ "Base_Board_Rework4,965,1,128,Base Board rework Info,0|"
+ "SOM_Board_Rework1,966,1,6,SOM Board Rework Info,0|"
+ "SOM_Board_Rework2,967,1,2,SOM Board Rework Info,0|"
+ "Eload_Board_Rework1,968,1,4,Eload Board Rework Info,0|"
+ "Eload_Board_Rework2,969,1,0,Eload Board Rework Info,0|"
+ "Noise_Board_Rework1,970,1,1,Noise Board Rewrok info,0|"
+ "Noise_Board_Rework2,971,1,0,Noise Board Rework Info,0|"
+ "Reserved,972,10,0,Reserved,0|"
+ "Reserved,982,10,0,Reserved,0|"
+ "DILIMTER,992,1,;,,1|"
+ "BLOCK_START,993,2,0A0A,Block Start,0|"
+ "BLOCK_ID,995,1,13,Cable_IR_Drop_Calibration,0|"
+ "Cable1_VBUS_IR_Drop_Resistance,996,2,114,VBUS IR Drop Resistance value,0|"
+ "Cable1_PA_CC2_IR_Drop_Resistance,998,2,930,CC1 IR Drop Resistance value,0|"
+ "Cable1_PA_CC1_IR_Drop_Resistance,1000,2,930,CC2 IR Drop Resistance value,0|"
+ "Cable2_PB_VBUS_IR_Drop_Resistance,1002,2,114,VBUS IR Drop Resistance value,0|"
+ "Cable2_PB_CC2_IR_Drop_Resistance,1004,2,930,CC1 IR Drop Resistance value,0|"
+ "Cable2_PB_CC1_IR_Drop_Resistance,1006,2,930,CC2 IR Drop Resistance value,0|"
+ "Reserved,1008,10,0,Reserved,0|"
+ "Reserved,1018,10,0,Reserved,0|"
+ "DILIMTER,1028,1,;,,1|"
+ "BLOCK_START,1029,2,0A0A,Block Start,0|"
+ "BLOCK_ID,1031,1,14,QC_Leagecy_Resistance_Calibration,0|"
+ "RDCP_DAT_RES_COMPENSATION,1032,2,2184,Rdcp_dat Compensation Value in Ohms [Divide by 100],0|"
+ "RDCP_DAT_LOWER_RESISTANCE,1034,2,2199,Rdcp_dat Lower Resistance Value in Ohms [Divide by 100],0|"
+ "RDCP_DAT_UPPER_RESISTANCE,1036,2,6270,Rdcp_dat Upper resistance value in Ohms [Divide by 100],0|"
+ "RDM_DWN_RES_COMPENSATION,1038,2,969,Rdm_dwn Compensation Value in Kohms [Divide by 100],0|"
+ "RDM_DWN_LOWER_RESISTANCE,1040,2,1445,Rdm_dwn Lower resistance value in Kohms [Divide by 100],0|"
+ "RDM_DWN_UPPER_RESISTANCE,1042,2,2509,Rdm_dwn Upper resistance value in Kohms [Divide by 100],0|"
+ "RDAT_LKG_RES_COMPENSATION,1044,2,0,Rdat_lkg Compensation value in Kohms [Divide by 1000],0|"
+ "RDAT_LKG_LOWER_RESISTANCE,1046,2,310,Rdat_lkg Lower resistance value in Kohms,0|"
+ "RDAT_LKG_UPPER_RESISTANCE,1048,2,1709,Rdat_lkg Upper resistance value in Kohms,0|"
+ "RDAT_LKG_MIDDLE_RESISTANCE,1050,2,492,Rdat_lkg Middle resistance value in Kohms,0|"
+ "RESERVED,1052,10,0,,0|"
+ "RESERVED,1062,10,0,,0|"
+ "DILIMTER,1072,1,;,,1|"
+ "BLOCK_START,1073,2,0A0A,Block Start,0|"
+ "BLOCK_ID,1075,1,15,F1R_EXT_IR_Drop_Calibration,0|"
+ "Type_EXT_PA_VBUS_IR_Drop_Resistance,1076,2,400,VBUS IR Drop Resistance value *10000,0|"
+ "Type_EXT_PA_CC2_IR_Drop_Resistance,1078,2,530,CC2 IR Drop Resistance value *1000,0|"
+ "Type_EXT_PA_CC1_IR_Drop_Resistance,1080,2,539,CC1 IR Drop Resistance value *1000,0|"
+ "Type_EXT_PB_VBUS_IR_Drop_Resistance,1082,2,377,VBUS IR Drop Resistance value *10000,0|"
+ "Type_EXT_PB_CC2_IR_Drop_Resistance,1084,2,399,CC2 IR Drop Resistance value *1000,0|"
+ "Type_EXT_PB_CC1_IR_Drop_Resistance,1086,2,336,CC1 IR Drop Resistance value *1000,0|"
+ "Reserved,1088,10,0,Reserved,0|"
+ "Reserved,1098,10,0,Reserved,0|"
+ "DILIMTER,1108,1,;,,1|"
+ "BLOCK_START,1109,2,0A0A,Block Start,0|"
+ "BLOCK_ID,1111,1,16,SOM_Ethernet_Settings,0|"
+ "ETHERNET_SETTINGS,1112,1,1,Ethernet Settings Present or not,0|"
+ "TOTAL_COUNT,1113,1,8,Total active Reg count in FRAM,0|"
+ "TOTAL_VALID_COUNT,1114,1,3,Valid Ref count,0|"
+ "ETHERNET_ADDRESS,1115,1,1,FixedAddress,0|"
+ "PAGE_NO,1116,1,2,Ethernet Page No,0|"
+ "REG_ADD,1117,2,24,Ethernet Reg Address of Page,0|"
+ "REG_DATA,1119,2,22086,Ethernet Reg Data of Reg Address,0|"
+ "DILIMTER,1121,1,;,,1|"
+ "ETHERNET_ADDRESS,1122,1,2,,0|"
+ "PAGE_NO,1123,1,0,Ethernet Page No,0|"
+ "REG_ADD,1124,2,16,Ethernet Reg Address of Page,0|"
+ "REG_DATA,1126,2,1120,Ethernet Reg Data of Reg Address,0|"
+ "DILIMTER,1128,1,;,,1|"
+ "ETHERNET_ADDRESS,1129,1,3,,0|"
+ "PAGE_NO,1130,1,0,Ethernet Page No,0|"
+ "REG_ADD,1131,2,0,Ethernet Reg Address of Page,0|"
+ "REG_DATA,1133,2,45312,Ethernet Reg Data of Reg Address,0|"
+ "DILIMTER,1135,1,;,,1|"
+ "ETHERNET_ADDRESS,1136,1,4,,0|"
+ "PAGE_NO,1137,1,10,Ethernet Page No,0|"
+ "REG_ADD,1138,2,11,Ethernet Reg Address of Page,0|"
+ "REG_DATA,1140,2,12,Ethernet Reg Data of Reg Address,0|"
+ "DILIMTER,1142,1,;,,1|"
+ "ETHERNET_ADDRESS,1143,1,5,,0|"
+ "PAGE_NO,1144,1,13,Ethernet Page No,0|"
+ "REG_ADD,1145,2,14,Ethernet Reg Address of Page,0|"
+ "REG_DATA,1147,2,15,Ethernet Reg Data of Reg Address,0|"
+ "DILIMTER,1149,1,;,,1|"
+ "ETHERNET_ADDRESS,1150,1,6,,0|"
+ "PAGE_NO,1151,1,16,Ethernet Page No,0|"
+ "REG_ADD,1152,2,17,Ethernet Reg Address of Page,0|"
+ "REG_DATA,1154,2,18,Ethernet Reg Data of Reg Address,0|"
+ "DILIMTER,1156,1,;,,1|"
+ "ETHERNET_ADDRESS,1157,1,7,,0|"
+ "PAGE_NO,1158,1,19,Ethernet Page No,0|"
+ "REG_ADD,1159,2,20,Ethernet Reg Address of Page,0|"
+ "REG_DATA,1161,2,21,Ethernet Reg Data of Reg Address,0|"
+ "DILIMTER,1163,1,;,,1|"
+ "ETHERNET_ADDRESS,1164,1,8,,0|"
+ "PAGE_NO,1165,1,22,Ethernet Page No,0|"
+ "REG_ADD,1166,2,23,Ethernet Reg Address of Page,0|"
+ "REG_DATA,1168,2,24,Ethernet Reg Data of Reg Address,0|"
+ "DILIMTER,1170,1,;,,1|"
+ "Reserved,1171,10,0,Reserved,0|"
+ "Reserved,1181,10,0,Reserved,0|"
+ "Reserved,1191,10,0,Reserved,0|"
+ "Reserved,1201,10,0,Reserved,0|"
+ "DILIMTER,1211,1,;,,1|"
+ "BLOCK_START,1212,2,0A0A,Block Start,0|"
+ "BLOCK_ID,1214,1,17,Functional VBUS Set,0|"
+ "External_Voltage,1215,1,1,VBUS-PortA,0|"
+ "UNIT,1216,1,V,Unit in VOLTAGE,1|"
+ "VOLTAGE1,1217,2,500,5000mV,0|"
+ "DAC_COUNT,1219,2,1168,,0|"
+ "VOLTAGE2,1221,2,370,3700mv,0|"
+ "DAC_COUNT,1223,2,2096,,0|"
+ "VOLTAGE3,1225,2,270,2700mV,0|"
+ "DAC_COUNT,1227,2,2736,,0|"
+ "VOLTAGE4,1229,2,170,1700mV,0|"
+ "DAC_COUNT,1231,2,3376,,0|"
+ "VOLTAGE5,1233,2,85,850mV,0|"
+ "DAC_COUNT,1235,2,3905,,0|"
+ "DILIMTER,1237,1,;,,1|"
+ "BLOCK_START,1238,2,0A0A,Block Start,0|"
+ "BLOCK_ID,1240,1,18,Cable_IR_Drop_Calibration_CUSTOMIZED TYPE-C Cable,0|"
+ "CABLE_NO,1241,1,1,GRL-SPECIAL Cable 1,0|"
+ "CALBE_NAME,1242,20,GRL-SPL CABLE 1,Cable Name,1|"
+ "CABL_VER_BIT,1262,1,0,Calibration Verification Bit,0|"
+ "PA_VBUS_RES,1263,2,0,PA VBUS IR Drop Resistance value,0|"
+ "PA_CC2_RES,1265,2,0,PA CC2 IR Drop Resistance value,0|"
+ "PA_CC1_RES,1267,2,0,PA CC1 IR Drop Resistance value,0|"
+ "PB_VBUS_RES,1269,2,0,PB VBUS IR Drop Resistance value,0|"
+ "PB_CC2_RES,1271,2,0,PB CC2 IR Drop Resistance value,0|"
+ "PB_CC1_RES,1273,2,0,PB CC1 IR Drop Resistance value,0|"
+ "DILIMTER,1275,1,;,,1|"
+ "CABLE_NO,1276,1,2,GRL-SPECIAL Cable 2,0|"
+ "CALBE_NAME,1277,20,GRL-SPL CABLE 2,Cable Name,1|"
+ "CABL_VER_BIT,1297,1,0,Calibration Verification Bit,0|"
+ "PA_VBUS_RES,1298,2,0,PA VBUS IR Drop Resistance value,0|"
+ "PA_CC2_RES,1300,2,0,PA CC2 IR Drop Resistance value,0|"
+ "PA_CC1_RES,1302,2,0,PA CC1 IR Drop Resistance value,0|"
+ "PB_VBUS_RES,1304,2,0,PB VBUS IR Drop Resistance value,0|"
+ "PB_CC2_RES,1306,2,0,PB CC2 IR Drop Resistance value,0|"
+ "PB_CC1_RES,1308,2,0,PB CC1 IR Drop Resistance value,0|"
+ "DILIMTER,1310,1,;,,1|"
+ "CABLE_NO,1311,1,3,Customer Cable 1,0|"
+ "CABL_VER_BIT,1312,20,CABLE NAME2,Cable Name,1|"
+ "CALBE_NAME,1332,1,0,Calibration Verification Bit,0|"
+ "PA_VBUS_RES,1333,2,0,PA VBUS IR Drop Resistance value,0|"
+ "PA_CC2_RES,1335,2,0,PA CC2 IR Drop Resistance value,0|"
+ "PA_CC1_RES,1337,2,0,PA CC1 IR Drop Resistance value,0|"
+ "PB_VBUS_RES,1339,2,0,PB VBUS IR Drop Resistance value,0|"
+ "PB_CC2_RES,1341,2,0,PB CC2 IR Drop Resistance value,0|"
+ "PB_CC1_RES,1343,2,0,PB CC1 IR Drop Resistance value,0|"
+ "DILIMTER,1345,1,;,,1|"
+ "CABLE_NO,1346,1,4,Customer Cable 2,0|"
+ "CALBE_NAME,1347,20,CABLE NAME3,Cable Name,1|"
+ "CABL_VER_BIT,1367,1,0,Calibration Verification Bit,0|"
+ "PA_VBUS_RES,1368,2,0,PA VBUS IR Drop Resistance value,0|"
+ "PA_CC2_RES,1370,2,0,PA CC2 IR Drop Resistance value,0|"
+ "PA_CC1_RES,1372,2,0,PA CC1 IR Drop Resistance value,0|"
+ "PB_VBUS_RES,1374,2,0,PB VBUS IR Drop Resistance value,0|"
+ "PB_CC2_RES,1376,2,0,PB CC2 IR Drop Resistance value,0|"
+ "PB_CC1_RES,1378,2,0,PB CC1 IR Drop Resistance value,0|"
+ "DILIMTER,1380,1,;,,1|"
+ "BLOCK_START,1381,2,0A0A,,0|"
+ "BLOCK_ID,1383,1,19,Block ID 19: Serial Number block [ Fixed during Production],0|"
+ "FIX_SYSTEM_SERIAL_NUMBER,1384,2,240,Serial Number of System,0|"
+ "FIX_SOM_BOARD_NUMBER,1386,2,257,Serial Numebr of SOM board,0|"
+ "FIX_SOM_BOARD_REV,1388,1,5,SOM Board Revision,0|"
+ "FIX_BASE_BOARD_NUMBER,1389,2,240,Serial Numebr of Base Board,0|"
+ "FIX_BASE_BOARD_REV,1391,1,6,Revision Number of Base Board,0|"
+ "FIX_ELOAD_NUMBER,1392,2,310,Serial Number of E-Load,0|"
+ "FIX_ELOAD_REV,1394,1,2,E-Load Revision,0|"
+ "FIX_NOISE_NUMBER,1395,2,168,Serial Number of Noise Board,0|"
+ "FIX_NOISE_REV,1397,1,2,Revision Number of Noise Board,0|"
+ "Reserved,1398,10,0,Reserved,0|"
+ "Reserved,1408,10,0,Reserved,0|"
+ "DILIMTER,1418,1,;,,1|"
+ "END_FRAM,1419,1,;,,1|"
+ "END_FRAM,1420,1,;,,1|"
+ "END_FRAM,1421,1,;,,1";
    }
}
