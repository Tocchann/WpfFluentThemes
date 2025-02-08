# .NET 9 ����� WPF �ŕς���������������炢���悤

## �A�W�F���_

- WPF for .NET 9 �̎�ȕύX�_
- �V����UI�������ɔ����ω�
- field �v���p�e�B�����ɂ��ǐ��̌���
- BinaryFormatter �̃T�|�[�g�I���ɔ����ω�
- �܂Ƃ�

## WPF for .NET 9 �̎�ȕύX�_

- Fluent UI �e�[�}�̑g�ݍ��ݑΉ�
- ThemeMode �̓���
- Windows �A�N�Z���g�J���[�̃T�|�[�g
- �n�C�t���x�[�X�̍����T�|�[�g
- BinaryFormatter �̃T�|�[�g�I��
- field �v���p�e�B�̒ǉ�(���݃v���r���[)

�ڂ�����[WPF for .NET 9 �̐V�@�\](https://learn.microsoft.com/ja-jp/dotnet/desktop/wpf/whats-new/net90?WT.mc_id=DT-MVP-32182&view=netdesktop-9.0)���Q��

## Fluent UI �e�[�}�̑g�ݍ��ݑΉ�

- �����ڂ̕ω��ɔ����ύX�_
- ���C�A�E�g�̍l�������ς������
- �g���Ȃ��Ȃ����ݒ�
- �A�N�Z���g�J���[�̒�`

## �����ڂ̕ω��ɔ����ύX�_

- Label/TextBox/TextBlock �̍����������ɂȂ���(���C�A�E�g���₷���Ȃ�������)
- ListBox �� ListView �̑I����Ԃ��قȂ�`�ɕύX���ꂽ
    - Fluent UI �ŗ��p����ꍇ�́AListView ���g���ق����ǂ�
- RadioButton �̖�����Ԃ̓R���g���[���S�悪�h��Ԃ�
- CheckBox �̋�`�O���t�B�b�N�͈���傫���Ȃ���
    - �W���I�ȃe�L�X�g�T�C�Y�Ȃ�{�^�������̂ق����傫��

## ���C�A�E�g�̍l�������ς������

- �{�^�����C�A�E�g���啝�ɕς����
- �]��
    - �e����񋟂����̈��S�ė��p����
- Fluent UI
    - �{�^���R���e���c�̑傫�����ő�l�Ƃ���
    - �c�����͒����񂹁A�������͍���
    - Grid�p�l���ŗ̈�v�Z���Ă���Ƒz��O�̈ʒu�ɗ���

## �g���Ȃ��Ȃ����ݒ�

- ListView-GridView ���g���Ȃ��Ȃ���
- �����ւ� DataGrid �ŁAReadOnly���[�h�ɂ��邱�Ƃ��炢�����Ȃ�

## �A�N�Z���g�J���[�̒�`

- DynamicResource �Ƃ��Ċe��A�N�Z���g�J���[���������ꂽ�B
- DynamicResource �Ȃ̂ŏ�ԕύX�ɔ����ω�����
- �F�����ł͂Ȃ��A�R���g���[���ɂ��X�^�C�����p�ӂ���Ă���

## field �v���p�e�B�����ɂ��ǐ��̌���

- �܂��A�����ł͂Ȃ��̂� .csproj ��`<LangVersion>preview</LangVersion>`���K�v
- SourceGenerator ���g���Ă���ꍇ�ɗL��
    - �����ŋL�q����ꍇ�ł����p�\
    - �菑���Ƀ����b�g������킯�ł͂Ȃ�
- CommunityToolkit.MVVM �ŗ��p���Ă���
    - field �v���p�e�B���g���Ď����������邱�ƂŁASourceGenerator �ɂ�鎩���������\�ɂȂ���

## BinaryFormatter �̃T�|�[�g�I���ɔ����ω�

- �N���b�v�{�[�h�Ȃǂɕۑ����Ă���ꍇ�Ȃǂŉe�����o��u***�ꍇ������***�v
    - �N���b�v�{�[�h�ւ̃f�[�^�i�[�� DataFormats.Serializable ��J�X�^���`���𗘗p���Ă���ꍇ�ɉe��
- �����v���~�e�B�u�Ȍ^�ł���΂قډe�����Ȃ�
    - string �� DateTime�Abool�Aint�Ȃǂ͉e�����Ȃ�
- �t�@�C���̏ꍇ�̓o�C�i���_���v������
- �N���b�v�{�[�h�Ȃ�ANative�A�v���̃N���b�v�{�[�h�r�����[�𗘗p����

## ���̂ق��� .NET ����̕ύX�_

- .NET 9 �֘A
- .NET MAUI �֘A

## �܂Ƃ�

- WPF �̃t���[�����[�N�P�̂� UWP �Ɠ��� Fluent UI �����p�\�ɂȂ���
    - WinUI 3 �Ƃ̐e�a������ւ̑���
- �����̃t���[�����[�N�̑Ή��͂��ꂩ��
    - �A�N�e�B�u�ȃt���[�����[�N�̃��|�W�g����������肱�ꂩ��