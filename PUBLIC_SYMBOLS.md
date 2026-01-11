# PUBLIC_SYMBOLS.md

This file documents the public/internal symbols discovered during initial analysis and the planned handling for the refactor/english-identifiers branch.

Repository: Tel-Com/NOC_Actions
Branch: refactor/english-identifiers

Detected public/internal symbols (non-exhaustive, discovered so far):

- NOC_Actions.Program (internal) - Program.Main
- NOC_Actions.MainForm (partial) - Form (UI)
- NOC_Actions.LoginUser (partial) - Form (UI)
- NOC_Actions.InterfaceClienteInformes (public partial class) - Form
- NOC_Actions.AvisosSolicitacoesAoCliente (public partial class) - Form
- Multiple UserControl classes (public partial):
  - Uc_AnaliseDeInfra
  - UcAberturaDeReparo (UcAberturaReparo file contains class UcAberturaDeReparo)
  - UcAlarmeDeLinkIndisponivel
  - UcDetalharFaturaDoCliente
  - UcLiberacaoAcessoComPrevisao / UcLiberacaoDeAcessoComPrevisao / UcLiberacaoDeAcessoSemPrevisao
  - UcPendenciaFinanceiraInformes
  - UcPossivelQuedaDeEnergia
  - UcRegistroDeOcorrenciaInterna
- ArquivosComInformacoes.Class_Arquivos_Uc_AnaliseDeInfra (public class) - provides file I/O APIs such as SalvarOperadora, ObterOperadoras, etc.

Planned handling rules (summary):

1) Public UI classes (Form/UserControl types):
   - Keep class names and control Text properties working. We will *avoid* renaming public UI types that may be referenced externally unless necessary.
   - If renaming a public type, we will add a legacy wrapper class with the old name marked [Obsolete] that forwards to the new type to preserve binary/compile compatibility.

2) Public methods on helper classes (e.g., Class_Arquivos_Uc_AnaliseDeInfra):
   - For public methods that are part of an internal utility and unlikely used externally, we will rename to English and keep compatibility wrappers where feasible.
   - For methods that appear public but are internal to the app, we will consider making them internal if safe.

3) Control identifiers and private methods inside Forms/UserControls:
   - Rename control identifiers (e.g., btnSalvar -> btnSave) using automated refactor so Designer.cs and .resx links update consistently. Preserve Text values in Portuguese.
   - Rename private helper methods and fields to English (camelCase/_privateField) following .editorconfig rules.

4) File renames (.cs):
   - Rename .cs files when the contained primary type is renamed (e.g., FormDetalhesDoContrato.cs -> ContractDetailsForm.cs) only when translation is clear. Keep commits atomic and small.

5) Build & test after each batch. If any build error appears, revert the batch and attempt a safer approach (wrappers or skipping that rename).

Next steps (immediate):
- Produce small, safe renames focused on private members and control identifiers for a few primary forms (MainForm, LoginUser, UcAberturaReparo) and run dotnet build.
- Append each performed rename to MAPPING.md.

Notes:
- This analysis was generated automatically from the repository snapshot on branch refactor/english-identifiers. It may be incomplete; a full Roslyn symbol scan will be executed during the refactor to ensure coverage.
