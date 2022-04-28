using GraphMolWrap;

using var rxn = ChemicalReaction.ReactionFromSmarts("[C:1](=[O:2])-[OD1].[N!H0:3]>>[C:1](=[O:2])[N:3]");

Console.WriteLine(rxn.getNumProductTemplates());

Console.WriteLine("Running the reaction...");

using var reactant1 = RWMol.MolFromSmiles("C(COC(=O)O)C(=O)O");
using var reactant2 = RWMol.MolFromSmiles("NC");
using var vect = new ROMol_Vect(new[] {reactant1, reactant2});
using var ps = rxn.runReactants(vect);

Console.WriteLine($"Generated {ps.Count} products. Printing them...");

foreach (var products in ps)
{
    Console.WriteLine(products[0].MolToSmiles());
}
