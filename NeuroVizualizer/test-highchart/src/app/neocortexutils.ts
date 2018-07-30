import { NeoCortexModel, Area, Synapse, Minicolumn, Cell, neocortexSettings } from './neocortexmodel';




export class neoCortexUtils {

 

  public static createModel(areas: number=1, minicolumns: number[]= [1000,3], cellsInMinicolumn: number=6) : NeoCortexModel { 

    var  sett :  neocortexSettings = { areas: areas, minicolumns: minicolumns, cellsInMinicolumn: cellsInMinicolumn  };

    var  model:NeoCortexModel = new NeoCortexModel(sett);

    return model; 
  }
}



