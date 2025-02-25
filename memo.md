# .NET 9 ����� WPF �ŕς���������������炢���悤

## �A�W�F���_

- WPF for .NET 9 �̎�ȕύX�_
- field �v���p�e�B�̓���(����Preview)
- �܂Ƃ�

## WPF for .NET 9 �̎�ȕύX�_

- Fluent UI �e�[�}�̑g�ݍ��ݑΉ�
- ThemeMode �̓���
- Windows �A�N�Z���g�J���[�̃T�|�[�g
- �n�C�t���x�[�X�̍����T�|�[�g
- BinaryFormatter �̃T�|�[�g�I��

�ڂ�����[WPF for .NET 9 �̐V�@�\](https://learn.microsoft.com/ja-jp/dotnet/desktop/wpf/whats-new/net90?WT.mc_id=DT-MVP-32182&view=netdesktop-9.0)���Q��

## Fluent UI �e�[�}�̑g�ݍ��ݑΉ�

- �����ڂ̕ω��ɔ����ύX�_
- �{�^�����C�A�E�g�̕ύX
- �g���Ȃ��Ȃ������[�h
- �A�N�Z���g�J���[�̓���

## �����ڂ̕ω��ɔ����ύX�_

- Label/TextBox/TextBlock �̍����������ɂȂ���
- ListBox �� ListView �̑I����Ԃ��قȂ�`�ɕύX���ꂽ
    - Fluent UI �ŗ��p����ꍇ�́AListView �̂ق����e�a���͍�������
- RadioButton �̖�����Ԃ̓R���g���[���S���h��Ԃ�
- CheckBox �̋�`�O���t�B�b�N�͈���傫���Ȃ���
    - �W���I�ȃe�L�X�g�T�C�Y�Ȃ�{�^�������̂ق����傫��

## �{�^�����C�A�E�g�̕ύX

- �{�^�����C�A�E�g
- �]��
    - �e����񋟂����̈��S�ė��p����
- Fluent UI
    - �{�^���R���e���c�̑傫�����ő�l�Ƃ���
    - �c�����͒����񂹁A�������͍���
        - Alignment �͗L��
    - Grid�p�l���ŗ̈�v�Z���Ă���Ƒz��O�̈ʒu�ɗ���

## �g���Ȃ��Ȃ������[�h

- ListView-GridView ���g���Ȃ��Ȃ���(.NET10�܂łɂǂ��Ȃ邩�͕s��)
- ��֎�i
    - DataGrid �� ReadOnly �Ŏg��(���S�݊��ł͂Ȃ�)

## �A�N�Z���g�J���[�̓���

- DynamicResource �Ƃ��Ċe��A�N�Z���g�J���[���������ꂽ�B
- DynamicResource �Ȃ̂ŏ�ԕύX�ɔ����ω�����
- �F�����ł͂Ȃ��A�R���g���[���ɂ��X�^�C�����p�ӂ���Ă���

## field �v���p�e�B�̓���(����Preview)

- �v���r���[�Ȃ̂� .csproj ��`<LangVersion>preview</LangVersion>`���K�v
- SourceGenerator ���g���Ă���ꍇ�ɗL��
    - �����ŋL�q����ꍇ�ł����p�\
    - �菑���ł��t�B�[���h���`���Ȃ��Ă悭�Ȃ���x�̌��ʂ͂���
- CommunityToolkit.MVVM �ŗ��p
    - field �v���p�e�B���g���Ď����������邱�ƂŁASourceGenerator �ɂ�鎩���������\�ɂȂ���
    - �����Ƃ̑g�ݍ��킹�̊��p�͈͂��L������

## BinaryFormatter �̃T�|�[�g�I���ɔ����ω�

- �N���b�v�{�[�h�Ȃǂɕۑ����Ă���ꍇ�Ȃǂŉe�����o��u***�ꍇ������***�v
    - DataFormats.Serializable �Ȃ�
- �����v���~�e�B�u�Ȍ^�ł���΂قډe�����Ȃ�
    - string �� DateTime�Abool�Aint�Abyte[] �Ȃǂ͉e�����Ȃ�

## �܂Ƃ�

- WPF �̃t���[�����[�N�P�̂� UWP �Ɠ����悤�� Fluent UI �����p�\�ɂȂ���
    - WinUI 3 �Ƃ̐e�a������ւ̑���
- �����̃t���[�����[�N�̑Ή�������̉ۑ�
    - �A�N�e�B�u�ȃt���[�����[�N�̃��|�W�g����������肱�ꂩ��

## �Q�l����
- .NET 9 �֘A
- .NET MAUI �֘A

