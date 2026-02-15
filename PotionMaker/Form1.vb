Public Class Form1

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        End
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.back
        PictureBox1.Image = My.Resources.brew
        cb_Speed2.SelectedItem = "true"
        cb_Slowness2.SelectedItem = "true"
        cb_Haste2.SelectedItem = "true"
        cb_Mining_Fatigue2.SelectedItem = "true"
        cb_Strengh2.SelectedItem = "true"
        cb_Instant_Health2.SelectedItem = "true"
        cb_Instant_Damage2.SelectedItem = "true"
        cb_Jump_Boost2.SelectedItem = "true"
        cb_Nausea2.SelectedItem = "true"
        cb_Regeneration2.SelectedItem = "true"
        cb_Resistance2.SelectedItem = "true"
        cb_Fire_Resistance2.SelectedItem = "true"
        cb_Water_Breathing2.SelectedItem = "true"
        cb_Invisibility2.SelectedItem = "true"
        cb_Blindness2.SelectedItem = "true"
        cb_Night_Vision2.SelectedItem = "true"
        cb_Hunger2.SelectedItem = "true"
        cb_Weakness2.SelectedItem = "true"
        cb_Poison2.SelectedItem = "true"
        cb_Wither2.SelectedItem = "true"
        cb_Health_Boost2.SelectedItem = "true"
        cb_Absorbtion2.SelectedItem = "true"
        cb_Saturation2.SelectedItem = "true"
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        If cb_All.Checked = True Then
            gen_All()
        ElseIf cb_All.Checked = False Then
            gen()
        End If
    End Sub

    Private Sub gen()
        If CheckBox1.Checked = True Then
            TextBox1.Text = "/give @p potion 1 "
            If ComboBox1.Text = "Design" Then
                TextBox1.Text &= TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Waterbottle" Then
                TextBox1.Text &= TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Regeneration" Then
                TextBox1.Text &= TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Swiftness" Then
                TextBox1.Text &= TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Fire Resisitance" Then
                TextBox1.Text &= TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Poison" Then
                TextBox1.Text &= TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Healing" Then
                TextBox1.Text &= TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Night Vision" Then
                TextBox1.Text &= TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Weakness" Then
                TextBox1.Text &= TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Strength" Then
                TextBox1.Text &= TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Slowness" Then
                TextBox1.Text &= TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Leaping" Then
                TextBox1.Text &= TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Harming" Then
                TextBox1.Text &= TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Water Breathing" Then
                TextBox1.Text &= TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Invisibility" Then
                TextBox1.Text &= TextBox3.Text & " "
            Else
                MsgBox("Please choose a Design", MsgBoxStyle.Exclamation, "Error")
            End If
        ElseIf CheckBox1.Checked = False Then
            TextBox1.Text = "/give @p potion 1 "
            If ComboBox1.Text = "Design" Then
                TextBox1.Text &= "0 "
            ElseIf ComboBox1.Text = "Waterbottle" Then
                TextBox1.Text &= "0 "
            ElseIf ComboBox1.Text = "Potion of Regeneration" Then
                TextBox1.Text &= "1 "
            ElseIf ComboBox1.Text = "Potion of Swiftness" Then
                TextBox1.Text &= "2 "
            ElseIf ComboBox1.Text = "Potion of Fire Resisitance" Then
                TextBox1.Text &= "3 "
            ElseIf ComboBox1.Text = "Potion of Poison" Then
                TextBox1.Text &= "4 "
            ElseIf ComboBox1.Text = "Potion of Healing" Then
                TextBox1.Text &= "5 "
            ElseIf ComboBox1.Text = "Potion of Night Vision" Then
                TextBox1.Text &= "6 "
            ElseIf ComboBox1.Text = "Potion of Weakness" Then
                TextBox1.Text &= "7 "
            ElseIf ComboBox1.Text = "Potion of Strength" Then
                TextBox1.Text &= "8 "
            ElseIf ComboBox1.Text = "Potion of Slowness" Then
                TextBox1.Text &= "9 "
            ElseIf ComboBox1.Text = "Potion of Leaping" Then
                TextBox1.Text &= "10 "
            ElseIf ComboBox1.Text = "Potion of Harming" Then
                TextBox1.Text &= "11 "
            ElseIf ComboBox1.Text = "Potion of Water Breathing" Then
                TextBox1.Text &= "12 "
            ElseIf ComboBox1.Text = "Potion of Invisibility" Then
                TextBox1.Text &= "13 "
            Else
                MsgBox("Please choose a Design", MsgBoxStyle.Exclamation, "Error")
            End If
        End If
        TextBox1.Text = TextBox1.Text & "{display:{Name:" & TextBox2.Text & "},CustomPotionEffects:["
        '{id:cb_[]1,Duration:txt_[]1,Amplifier:txt_[]2,ShowParticles:cb_[]2}
        If cb_Speed1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:1,Duration:" & txt_Speed1.Text & ",Amplifier:" & txt_Speed2.Text & ",ShowParticles:" & cb_Speed2.Text & "},"
        End If
        If cb_Slowness1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:2,Duration:" & txt_Slowness1.Text & ",Amplifier:" & txt_Slowness2.Text & ",ShowParticles:" & cb_Slowness2.Text & "},"
        End If
        If cb_Haste1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:3,Duration:" & txt_Haste1.Text & ",Amplifier:" & txt_Haste2.Text & ",ShowParticles:" & cb_Haste2.Text & "},"
        End If
        If cb_Mining_Fatigue1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:4,Duration:" & txt_Mining_Fatigue1.Text & ",Amplifier:" & txt_Speed2.Text & ",ShowParticles:" & cb_Speed2.Text & "},"
        End If
        If cb_Strengh1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:5,Duration:" & txt_Strengh1.Text & ",Amplifier:" & txt_Strengh2.Text & ",ShowParticles:" & cb_Strengh2.Text & "},"
        End If
        If cb_Instant_Health1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:6,Duration:" & txt_Instant_Health1.Text & ",Amplifier:" & txt_Instant_Health2.Text & ",ShowParticles:" & cb_Instant_Health2.Text & "},"
        End If
        If cb_Instant_Damage1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:7,Duration:" & txt_Instant_Damage1.Text & ",Amplifier:" & txt_Instant_Damage2.Text & ",ShowParticles:" & cb_Instant_Damage2.Text & "},"
        End If
        If cb_Jump_Boost1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:8,Duration:" & txt_Jump_Boost1.Text & ",Amplifier:" & txt_Jump_Boost2.Text & ",ShowParticles:" & cb_Jump_Boost2.Text & "},"
        End If
        If cb_Nausea1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:9,Duration:" & txt_Nausea1.Text & ",Amplifier:" & txt_Nausea2.Text & ",ShowParticles:" & cb_Nausea2.Text & "},"
        End If
        If cb_Regeneration1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:10,Duration:" & txt_Regeneration1.Text & ",Amplifier:" & txt_Regeneration2.Text & ",ShowParticles:" & cb_Regeneration2.Text & "},"
        End If
        If cb_Resistance1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:11,Duration:" & txt_Resistance1.Text & ",Amplifier:" & txt_Resistance2.Text & ",ShowParticles:" & cb_Resistance2.Text & "},"
        End If
        If cb_Fire_Resistance1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:12,Duration:" & txt_Fire_Resistance1.Text & ",Amplifier:" & txt_Fire_Resistance2.Text & ",ShowParticles:" & cb_Fire_Resistance2.Text & "},"
        End If
        If cb_Water_Breathing1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:13,Duration:" & txt_Water_Breathing1.Text & ",Amplifier:" & txt_Water_Breathing2.Text & ",ShowParticles:" & cb_Water_Breathing2.Text & "},"
        End If
        If cb_Invisibility1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:14,Duration:" & txt_Invisibility1.Text & ",Amplifier:" & txt_Invisibility2.Text & ",ShowParticles:" & cb_Invisibility2.Text & "},"
        End If
        If cb_Blindness1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:15,Duration:" & txt_Blindness1.Text & ",Amplifier:" & txt_Blindness2.Text & ",ShowParticles:" & cb_Blindness2.Text & "},"
        End If
        If cb_Night_Vision1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:16,Duration:" & txt_Night_Vision1.Text & ",Amplifier:" & txt_Night_Vision2.Text & ",ShowParticles:" & cb_Night_Vision2.Text & "},"
        End If
        If cb_Hunger1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:17,Duration:" & txt_Hunger1.Text & ",Amplifier:" & txt_Hunger2.Text & ",ShowParticles:" & cb_Hunger2.Text & "},"
        End If
        If cb_Weakness1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:18,Duration:" & txt_Weakness1.Text & ",Amplifier:" & txt_Weakness2.Text & ",ShowParticles:" & cb_Weakness2.Text & "},"
        End If
        If cb_Poison1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:19,Duration:" & txt_Poison1.Text & ",Amplifier:" & txt_Poison2.Text & ",ShowParticles:" & cb_Poison2.Text & "},"
        End If
        If cb_Wither1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:20,Duration:" & txt_Wither1.Text & ",Amplifier:" & txt_Wither2.Text & ",ShowParticles:" & cb_Wither2.Text & "},"
        End If
        If cb_Health_Boost1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:21,Duration:" & txt_Health_Boost1.Text & ",Amplifier:" & txt_Health_Boost2.Text & ",ShowParticles:" & cb_Health_Boost2.Text & "},"
        End If
        If cb_Absorbtion1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:22,Duration:" & txt_Absorbtion1.Text & ",Amplifier:" & txt_Absorbtion2.Text & ",ShowParticles:" & cb_Absorbtion2.Text & "},"
        End If
        If cb_Saturation1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:23,Duration:" & txt_Saturation1.Text & ",Amplifier:" & txt_Saturation2.Text & ",ShowParticles:" & cb_Saturation2.Text & "},"
        End If
        TextBox1.Text = TextBox1.Text & "]}"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Design" Then
            TextBox3.Text = "0"
        ElseIf ComboBox1.Text = "Waterbottle" Then
            TextBox3.Text = "0"
        ElseIf ComboBox1.Text = "Potion of Regeneration" Then
            TextBox3.Text = "1"
        ElseIf ComboBox1.Text = "Potion of Swiftness" Then
            TextBox3.Text = "2"
        ElseIf ComboBox1.Text = "Potion of Fire Resisitance" Then
            TextBox3.Text = "3"
        ElseIf ComboBox1.Text = "Potion of Poison" Then
            TextBox3.Text = "4"
        ElseIf ComboBox1.Text = "Potion of Healing" Then
            TextBox3.Text = "5"
        ElseIf ComboBox1.Text = "Potion of Night Vision" Then
            TextBox3.Text = "6"
        ElseIf ComboBox1.Text = "Potion of Weakness" Then
            TextBox3.Text = "7"
        ElseIf ComboBox1.Text = "Potion of Strength" Then
            TextBox3.Text = "8"
        ElseIf ComboBox1.Text = "Potion of Slowness" Then
            TextBox3.Text = "9"
        ElseIf ComboBox1.Text = "Potion of Leaping" Then
            TextBox3.Text = "10"
        ElseIf ComboBox1.Text = "Potion of Harming" Then
            TextBox3.Text = "11"
        ElseIf ComboBox1.Text = "Potion of Water Breathing" Then
            TextBox3.Text = "12"
        ElseIf ComboBox1.Text = "Potion of Invisibility" Then
            TextBox3.Text = "13"
        End If
        TextBox3.Text = TextBox3.Text + 16384
    End Sub

    Private Sub cb_All_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb_All.CheckedChanged
        If cb_All.Checked = True Then
            txt_Duration_All.Visible = True
            txt_Amplifier_All.Visible = True
            cb_Particles_All.Visible = True
            Settings_enabled_off()
        ElseIf cb_All.Checked = False Then
            txt_Duration_All.Visible = False
            txt_Amplifier_All.Visible = False
            cb_Particles_All.Visible = False
            Settings_enabled_on()
        End If
    End Sub

    Private Sub gen_All()
        If CheckBox1.Checked = True Then
            TextBox1.Text = "/give @p potion 1 "
            If ComboBox1.Text = "Design" Then
                TextBox1.Text = TextBox1.Text & TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Waterbottle" Then
                TextBox1.Text = TextBox1.Text & TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Regeneration" Then
                TextBox1.Text = TextBox1.Text & TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Swiftness" Then
                TextBox1.Text = TextBox1.Text & TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Fire Resisitance" Then
                TextBox1.Text = TextBox1.Text & TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Poison" Then
                TextBox1.Text = TextBox1.Text & TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Healing" Then
                TextBox1.Text = TextBox1.Text & TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Night Vision" Then
                TextBox1.Text = TextBox1.Text & TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Weakness" Then
                TextBox1.Text = TextBox1.Text & TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Strength" Then
                TextBox1.Text = TextBox1.Text & TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Slowness" Then
                TextBox1.Text = TextBox1.Text & TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Leaping" Then
                TextBox1.Text = TextBox1.Text & TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Harming" Then
                TextBox1.Text = TextBox1.Text & TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Water Breathing" Then
                TextBox1.Text = TextBox1.Text & TextBox3.Text & " "
            ElseIf ComboBox1.Text = "Potion of Invisibility" Then
                TextBox1.Text = TextBox1.Text & TextBox3.Text & " "
            Else
                MsgBox("Please choose a Design", MsgBoxStyle.Exclamation, "Error")
            End If
        ElseIf CheckBox1.Checked = False Then
            TextBox1.Text = "/give @p potion 1 "
            If ComboBox1.Text = "Design" Then
                TextBox1.Text = TextBox1.Text & "0 "
            ElseIf ComboBox1.Text = "Waterbottle" Then
                TextBox1.Text = TextBox1.Text & "0 "
            ElseIf ComboBox1.Text = "Potion of Regeneration" Then
                TextBox1.Text = TextBox1.Text & "1 "
            ElseIf ComboBox1.Text = "Potion of Swiftness" Then
                TextBox1.Text = TextBox1.Text & "2 "
            ElseIf ComboBox1.Text = "Potion of Fire Resisitance" Then
                TextBox1.Text = TextBox1.Text & "3 "
            ElseIf ComboBox1.Text = "Potion of Poison" Then
                TextBox1.Text = TextBox1.Text & "4 "
            ElseIf ComboBox1.Text = "Potion of Healing" Then
                TextBox1.Text = TextBox1.Text & "5 "
            ElseIf ComboBox1.Text = "Potion of Night Vision" Then
                TextBox1.Text = TextBox1.Text & "6 "
            ElseIf ComboBox1.Text = "Potion of Weakness" Then
                TextBox1.Text = TextBox1.Text & "7 "
            ElseIf ComboBox1.Text = "Potion of Strength" Then
                TextBox1.Text = TextBox1.Text & "8 "
            ElseIf ComboBox1.Text = "Potion of Slowness" Then
                TextBox1.Text = TextBox1.Text & "9 "
            ElseIf ComboBox1.Text = "Potion of Leaping" Then
                TextBox1.Text = TextBox1.Text & "10 "
            ElseIf ComboBox1.Text = "Potion of Harming" Then
                TextBox1.Text = TextBox1.Text & "11 "
            ElseIf ComboBox1.Text = "Potion of Water Breathing" Then
                TextBox1.Text = TextBox1.Text & "12 "
            ElseIf ComboBox1.Text = "Potion of Invisibility" Then
                TextBox1.Text = TextBox1.Text & "13 "
            Else
                MsgBox("Please choose a Design", MsgBoxStyle.Exclamation, "Error")
            End If
        End If
        TextBox1.Text = TextBox1.Text & "{display:{Name:" & TextBox2.Text & "},CustomPotionEffects:["
        '{id:cb_[]1,Duration:txt_[]1,Amplifier:txt_[]2,ShowParticles:cb_[]2}
        If cb_Speed1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:1,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Slowness1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:2,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Haste1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:3,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Mining_Fatigue1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:4,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Strengh1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:5,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Instant_Health1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:6,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Instant_Damage1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:7,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Jump_Boost1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:8,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Nausea1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:9,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Regeneration1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:10,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Resistance1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:11,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Fire_Resistance1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:12,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Water_Breathing1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:13,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Invisibility1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:14,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Blindness1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:15,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Night_Vision1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:16,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Hunger1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:17,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Weakness1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:18,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Poison1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:19,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Wither1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:20,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Health_Boost1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:21,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Absorbtion1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:22,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        If cb_Saturation1.Checked = True Then
            TextBox1.Text = TextBox1.Text & "{Id:23,Duration:" & txt_Duration_All.Text & ",Amplifier:" & txt_Amplifier_All.Text & ",ShowParticles:" & cb_Particles_All.Text & "},"
        End If
        TextBox1.Text = TextBox1.Text & "]}"
    End Sub

    Private Sub SaveCommandToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveCommandToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        End
    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CreditsToolStripMenuItem.Click
        If CreditsToolStripMenuItem.Text = "Credits" Then
            MsgBox("Idea and Template by HeroLine1999." & vbCrLf & "Programmed and Designed by Dominik and Simon.", MsgBoxStyle.Information, "Credits")
        ElseIf CreditsToolStripMenuItem.Text = "Ersteller" Then
            MsgBox("Idee und Vorlage von HeroLine1999." & vbCrLf & "Programmiert und Designed von Dominik und Simon.", MsgBoxStyle.Information, "Ersteller")
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem4.Click
        If ToolStripMenuItem4.Text = "?" Then
            MsgBox("Choose the Effects you want to use in your own custom Potion in Minecraft." & vbCrLf & "Then click on the picture of the Brewing Stand.", MsgBoxStyle.Information, "Help")
        ElseIf ToolStripMenuItem4.Text = "? " Then
            MsgBox("Wähle die Effekte, die du in deinem eigenem Trank in Minecraft haben möchtest." & vbCrLf & "Klicke dann auf das Bild von dem Braustand.", MsgBoxStyle.Information, "Hilfe")
        End If
    End Sub

    Private Sub txt_Speed1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Speed1.Click
        If txt_Speed1.Text = "Duration" Or txt_Speed1.Text = "Dauer" Then
            txt_Speed1.Text = ""
        End If
    End Sub

    Private Sub txt_Speed2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Speed2.Click
        If txt_Speed2.Text = "Amplifier" Or txt_Speed2.Text = "Stärke" Then
            txt_Speed2.Text = ""
        End If
    End Sub

    Private Sub txt_Slowness1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Slowness1.Click
        If txt_Slowness1.Text = "Duration" Or txt_Slowness1.Text = "Dauer" Then
            txt_Slowness1.Text = ""
        End If
    End Sub

    Private Sub txt_Slowness2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Slowness2.Click
        If txt_Slowness2.Text = "Amplifier" Or txt_Speed2.Text = "Stärke" Then
            txt_Slowness2.Text = ""
        End If
    End Sub

    Private Sub txt_Haste1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Haste1.Click
        If txt_Haste1.Text = "Duration" Or txt_Haste1.Text = "Dauer" Then
            txt_Haste1.Text = ""
        End If
    End Sub

    Private Sub txt_Haste2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Haste2.Click
        If txt_Haste2.Text = "Amplifier" Or txt_Haste2.Text = "Stärke" Then
            txt_Haste2.Text = ""
        End If
    End Sub

    Private Sub txt_Mining_Fatigue1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Mining_Fatigue1.Click
        If txt_Mining_Fatigue1.Text = "Duration" Or txt_Mining_Fatigue1.Text = "Dauer" Then
            txt_Mining_Fatigue1.Text = ""
        End If
    End Sub

    Private Sub txt_Mining_Fatigue2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Mining_Fatigue2.Click
        If txt_Mining_Fatigue2.Text = "Amplifier" Or txt_Mining_Fatigue2.Text = "Stärke" Then
            txt_Mining_Fatigue2.Text = ""
        End If
    End Sub

    Private Sub txt_Strengh1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Strengh1.Click
        If txt_Strengh1.Text = "Duration" Or txt_Strengh1.Text = "Dauer" Then
            txt_Strengh1.Text = ""
        End If
    End Sub

    Private Sub txt_Strengh2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Strengh2.Click
        If txt_Strengh2.Text = "Amplifier" Or txt_Strengh2.Text = "Stärke" Then
            txt_Strengh2.Text = ""
        End If
    End Sub

    Private Sub txt_Instant_Health1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Instant_Health1.Click
        If txt_Instant_Health1.Text = "Duration" Or txt_Instant_Health1.Text = "Dauer" Then
            txt_Instant_Health1.Text = ""
        End If
    End Sub

    Private Sub txt_Instant_Health2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Instant_Health2.Click
        If txt_Instant_Health2.Text = "Amplifier" Or txt_Instant_Health2.Text = "Stärke" Then
            txt_Instant_Health2.Text = ""
        End If
    End Sub

    Private Sub txt_Instant_Damage1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Instant_Damage1.Click
        If txt_Instant_Damage1.Text = "Duration" Or txt_Instant_Damage1.Text = "Dauer" Then
            txt_Instant_Damage1.Text = ""
        End If
    End Sub

    Private Sub txt_Instant_Damage2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Instant_Damage2.Click
        If txt_Instant_Damage2.Text = "Amplifier" Or txt_Instant_Damage2.Text = "Stärke" Then
            txt_Instant_Damage2.Text = ""
        End If
    End Sub

    Private Sub txt_Jump_Boost1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Jump_Boost1.Click
        If txt_Jump_Boost1.Text = "Duration" Or txt_Jump_Boost1.Text = "Dauer" Then
            txt_Jump_Boost1.Text = ""
        End If
    End Sub

    Private Sub txt_Jump_Boost2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Jump_Boost2.Click
        If txt_Jump_Boost2.Text = "Amplifier" Or txt_Jump_Boost2.Text = "Stärke" Then
            txt_Jump_Boost2.Text = ""
        End If
    End Sub

    Private Sub txt_Nausea1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Nausea1.Click
        If txt_Nausea1.Text = "Duration" Or txt_Nausea1.Text = "Dauer" Then
            txt_Nausea1.Text = ""
        End If
    End Sub

    Private Sub txt_Nausea2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Nausea2.Click
        If txt_Nausea2.Text = "Amplifier" Or txt_Nausea2.Text = "Stärke" Then
            txt_Nausea2.Text = ""
        End If
    End Sub

    Private Sub txt_Regeneration1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Regeneration1.Click
        If txt_Regeneration1.Text = "Duration" Or txt_Regeneration1.Text = "Dauer" Then
            txt_Regeneration1.Text = ""
        End If
    End Sub

    Private Sub txt_Regeneration2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Regeneration2.Click
        If txt_Regeneration2.Text = "Amplifier" Or txt_Regeneration2.Text = "Stärke" Then
            txt_Regeneration2.Text = ""
        End If
    End Sub

    Private Sub txt_Resistance1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Resistance1.Click
        If txt_Resistance1.Text = "Duration" Or txt_Resistance1.Text = "Dauer" Then
            txt_Resistance1.Text = ""
        End If
    End Sub

    Private Sub txt_Resistance2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Resistance2.Click
        If txt_Resistance2.Text = "Amplifier" Or txt_Resistance2.Text = "Stärke" Then
            txt_Resistance2.Text = ""
        End If
    End Sub

    Private Sub txt_Fire_Resistance1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Fire_Resistance1.Click
        If txt_Fire_Resistance1.Text = "Duration" Or txt_Fire_Resistance1.Text = "Dauer" Then
            txt_Fire_Resistance1.Text = ""
        End If
    End Sub

    Private Sub txt_Fire_Resistance2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Fire_Resistance2.Click
        If txt_Fire_Resistance2.Text = "Amplifier" Or txt_Fire_Resistance2.Text = "Stärke" Then
            txt_Fire_Resistance2.Text = ""
        End If
    End Sub

    Private Sub txt_Water_Breathing1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Water_Breathing1.Click
        If txt_Water_Breathing1.Text = "Duration" Or txt_Water_Breathing1.Text = "Dauer" Then
            txt_Water_Breathing1.Text = ""
        End If
    End Sub

    Private Sub txt_Water_Breathing2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Water_Breathing2.Click
        If txt_Water_Breathing2.Text = "Amplifier" Or txt_Water_Breathing2.Text = "Stärke" Then
            txt_Water_Breathing2.Text = ""
        End If
    End Sub

    Private Sub txt_Invisibility1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Invisibility1.Click
        If txt_Invisibility1.Text = "Duration" Or txt_Invisibility1.Text = "Dauer" Then
            txt_Invisibility1.Text = ""
        End If
    End Sub

    Private Sub txt_Invisibility2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Invisibility2.Click
        If txt_Invisibility2.Text = "Amplifier" Or txt_Invisibility2.Text = "Stärke" Then
            txt_Invisibility2.Text = ""
        End If
    End Sub

    Private Sub txt_Blindness1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Blindness1.Click
        If txt_Blindness1.Text = "Duration" Or txt_Blindness1.Text = "Dauer" Then
            txt_Blindness1.Text = ""
        End If
    End Sub

    Private Sub txt_Blindness2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Blindness2.Click
        If txt_Blindness2.Text = "Amplifier" Or txt_Blindness2.Text = "Stärke" Then
            txt_Blindness2.Text = ""
        End If
    End Sub

    Private Sub txt_Night_Vision1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Night_Vision1.Click
        If txt_Night_Vision1.Text = "Duration" Or txt_Night_Vision1.Text = "Dauer" Then
            txt_Night_Vision1.Text = ""
        End If
    End Sub

    Private Sub txt_Night_Vision2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Night_Vision2.Click
        If txt_Night_Vision2.Text = "Amplifier" Or txt_Night_Vision2.Text = "Stärke" Then
            txt_Night_Vision2.Text = ""
        End If
    End Sub

    Private Sub txt_Hunger1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Hunger1.Click
        If txt_Hunger1.Text = "Duration" Or txt_Hunger1.Text = "Dauer" Then
            txt_Hunger1.Text = ""
        End If
    End Sub

    Private Sub txt_Hunger2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Hunger2.Click
        If txt_Hunger2.Text = "Amplifier" Or txt_Hunger2.Text = "Stärke" Then
            txt_Hunger2.Text = ""
        End If
    End Sub

    Private Sub txt_Weakness1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Weakness1.Click
        If txt_Weakness1.Text = "Duration" Or txt_Weakness1.Text = "Dauer" Then
            txt_Weakness1.Text = ""
        End If
    End Sub

    Private Sub txt_Weakness2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Weakness2.Click
        If txt_Weakness2.Text = "Amplifier" Or txt_Weakness2.Text = "Stärke" Then
            txt_Weakness2.Text = ""
        End If
    End Sub

    Private Sub txt_Poison1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Poison1.Click
        If txt_Poison1.Text = "Duration" Or txt_Poison1.Text = "Dauer" Then
            txt_Poison1.Text = ""
        End If
    End Sub

    Private Sub txt_Poison2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Poison2.Click
        If txt_Poison2.Text = "Amplifier" Or txt_Poison2.Text = "Stärke" Then
            txt_Poison2.Text = ""
        End If
    End Sub

    Private Sub txt_Wither1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Wither1.Click
        If txt_Wither1.Text = "Duration" Or txt_Wither1.Text = "Dauer" Then
            txt_Wither1.Text = ""
        End If
    End Sub

    Private Sub txt_Wither2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Wither2.Click
        If txt_Wither2.Text = "Amplifier" Or txt_Wither2.Text = "Stärke" Then
            txt_Wither2.Text = ""
        End If
    End Sub

    Private Sub txt_Health_Boost1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Health_Boost1.Click
        If txt_Health_Boost1.Text = "Duration" Or txt_Health_Boost1.Text = "Dauer" Then
            txt_Health_Boost1.Text = ""
        End If
    End Sub

    Private Sub txt_Health_Boost2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Health_Boost2.Click
        If txt_Health_Boost2.Text = "Amplifier" Or txt_Health_Boost2.Text = "Stärke" Then
            txt_Health_Boost2.Text = ""
        End If
    End Sub

    Private Sub txt_Absorbtion1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Absorbtion1.Click
        If txt_Absorbtion1.Text = "Duration" Or txt_Absorbtion1.Text = "Dauer" Then
            txt_Absorbtion1.Text = ""
        End If
    End Sub

    Private Sub txt_Absorbtion2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Absorbtion2.Click
        If txt_Absorbtion2.Text = "Amplifier" Or txt_Absorbtion2.Text = "Stärke" Then
            txt_Absorbtion2.Text = ""
        End If
    End Sub

    Private Sub txt_Saturation1_Click(sender As System.Object, e As System.EventArgs) Handles txt_Saturation1.Click
        If txt_Saturation1.Text = "Duration" Or txt_Saturation1.Text = "Dauer" Then
            txt_Saturation1.Text = ""
        End If
    End Sub

    Private Sub txt_Saturation2_Click(sender As System.Object, e As System.EventArgs) Handles txt_Saturation2.Click
        If txt_Saturation2.Text = "Amplifier" Or txt_Saturation2.Text = "Stärke" Then
            txt_Saturation2.Text = ""
        End If
    End Sub

    Private Sub txt_Duration_All_Click(sender As System.Object, e As System.EventArgs) Handles txt_Duration_All.Click
        If txt_Duration_All.Text = "Duration" Or txt_Duration_All.Text = "Dauer" Then
            txt_Duration_All.Text = ""
        End If
    End Sub

    Private Sub txt_Amplifier_All_Click(sender As System.Object, e As System.EventArgs) Handles txt_Amplifier_All.Click
        If txt_Amplifier_All.Text = "Amplifier" Or txt_Amplifier_All.Text = "Stärke" Then
            txt_Amplifier_All.Text = ""
        End If
    End Sub

    Private Sub TextBox2_Click(sender As System.Object, e As System.EventArgs) Handles TextBox2.Click
        If TextBox2.Text = "Name" Or TextBox2.Text = "name" Then
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub DeutsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeutsToolStripMenuItem.Click
        cb_Speed1.Text = "Geschwindigkeit"
        cb_Slowness1.Text = "Langsamkeit"
        cb_Haste1.Text = "Eile"
        cb_Mining_Fatigue1.Text = "Abbaulähmung"
        cb_Strengh1.Text = "Stärke"
        cb_Instant_Health1.Text = "Direktheilung"
        cb_Instant_Damage1.Text = "Sofortiger Schaden"
        cb_Jump_Boost1.Text = "Sprungkraft"
        cb_Nausea1.Text = "Übelkeit"
        'cb_Regeneration1.Text = "Regeneration"
        cb_Resistance1.Text = "Resistenz"
        cb_Fire_Resistance1.Text = "Feuerresistenz"
        cb_Water_Breathing1.Text = "Unterwasseratmung"
        cb_Invisibility1.Text = "Unsichtbarkeit"
        cb_Blindness1.Text = "Blindheit"
        cb_Night_Vision1.Text = "Nachtsicht"
        'cb_Hunger1.Text = "Hunger"
        cb_Weakness1.Text = "Schwäche"
        cb_Poison1.Text = "Vergiftung"
        'cb_Wither1.Text = "Wither"
        cb_Health_Boost1.Text = "Extraenergie"
        'cb_Absorbtion1.Text = "Absorbtion"
        cb_Saturation1.Text = "Sättigung"
        cb_Speed2.Items.Remove("true")
        cb_Speed2.Items.Remove("false")
        cb_Speed2.Items.Add("Ja")
        cb_Speed2.Items.Add("Nein")
        cb_Speed2.Text = "Partikel"
        cb_Slowness2.Items.Remove("true")
        cb_Slowness2.Items.Remove("false")
        cb_Slowness2.Items.Add("Ja")
        cb_Slowness2.Items.Add("Nein")
        cb_Slowness2.Text = "Partikel"
        cb_Haste2.Items.Remove("true")
        cb_Haste2.Items.Remove("false")
        cb_Haste2.Items.Add("Ja")
        cb_Haste2.Items.Add("Nein")
        cb_Haste2.Text = "Partikel"
        cb_Mining_Fatigue2.Items.Remove("true")
        cb_Mining_Fatigue2.Items.Remove("false")
        cb_Mining_Fatigue2.Items.Add("Ja")
        cb_Mining_Fatigue2.Items.Add("Nein")
        cb_Mining_Fatigue2.Text = "Partikel"
        cb_Strengh2.Items.Remove("true")
        cb_Strengh2.Items.Remove("false")
        cb_Strengh2.Items.Add("Ja")
        cb_Strengh2.Items.Add("Nein")
        cb_Strengh2.Text = "Partikel"
        cb_Instant_Health2.Items.Remove("true")
        cb_Instant_Health2.Items.Remove("false")
        cb_Instant_Health2.Items.Add("Ja")
        cb_Instant_Health2.Items.Add("Nein")
        cb_Instant_Health2.Text = "Partikel"
        cb_Instant_Damage2.Items.Remove("true")
        cb_Instant_Damage2.Items.Remove("false")
        cb_Instant_Damage2.Items.Add("Ja")
        cb_Instant_Damage2.Items.Add("Nein")
        cb_Instant_Damage2.Text = "Partikel"
        cb_Jump_Boost2.Items.Remove("true")
        cb_Jump_Boost2.Items.Remove("false")
        cb_Jump_Boost2.Items.Add("Ja")
        cb_Jump_Boost2.Items.Add("Nein")
        cb_Jump_Boost2.Text = "Partikel"
        cb_Nausea2.Items.Remove("true")
        cb_Nausea2.Items.Remove("false")
        cb_Nausea2.Items.Add("Ja")
        cb_Nausea2.Items.Add("Nein")
        cb_Nausea2.Text = "Partikel"
        cb_Regeneration2.Items.Remove("true")
        cb_Regeneration2.Items.Remove("false")
        cb_Regeneration2.Items.Add("Ja")
        cb_Regeneration2.Items.Add("Nein")
        cb_Regeneration2.Text = "Partikel"
        cb_Resistance2.Items.Remove("true")
        cb_Resistance2.Items.Remove("false")
        cb_Resistance2.Items.Add("Ja")
        cb_Resistance2.Items.Add("Nein")
        cb_Resistance2.Text = "Partikel"
        cb_Fire_Resistance2.Items.Remove("true")
        cb_Fire_Resistance2.Items.Remove("false")
        cb_Fire_Resistance2.Items.Add("Ja")
        cb_Fire_Resistance2.Items.Add("Nein")
        cb_Fire_Resistance2.Text = "Partikel"
        cb_Water_Breathing2.Items.Remove("true")
        cb_Water_Breathing2.Items.Remove("false")
        cb_Water_Breathing2.Items.Add("Ja")
        cb_Water_Breathing2.Items.Add("Nein")
        cb_Water_Breathing2.Text = "Partikel"
        cb_Invisibility2.Items.Remove("true")
        cb_Invisibility2.Items.Remove("false")
        cb_Invisibility2.Items.Add("Ja")
        cb_Invisibility2.Items.Add("Nein")
        cb_Invisibility2.Text = "Partikel"
        cb_Blindness2.Items.Remove("true")
        cb_Blindness2.Items.Remove("false")
        cb_Blindness2.Items.Add("Ja")
        cb_Blindness2.Items.Add("Nein")
        cb_Blindness2.Text = "Partikel"
        cb_Night_Vision2.Items.Remove("true")
        cb_Night_Vision2.Items.Remove("false")
        cb_Night_Vision2.Items.Add("Ja")
        cb_Night_Vision2.Items.Add("Nein")
        cb_Night_Vision2.Text = "Partikel"
        cb_Hunger2.Items.Remove("true")
        cb_Hunger2.Items.Remove("false")
        cb_Hunger2.Items.Add("Ja")
        cb_Hunger2.Items.Add("Nein")
        cb_Hunger2.Text = "Partikel"
        cb_Weakness2.Items.Remove("true")
        cb_Weakness2.Items.Remove("false")
        cb_Weakness2.Items.Add("Ja")
        cb_Weakness2.Items.Add("Nein")
        cb_Weakness2.Text = "Partikel"
        cb_Poison2.Items.Remove("true")
        cb_Poison2.Items.Remove("false")
        cb_Poison2.Items.Add("Ja")
        cb_Poison2.Items.Add("Nein")
        cb_Poison2.Text = "Partikel"
        cb_Wither2.Items.Remove("true")
        cb_Wither2.Items.Remove("false")
        cb_Wither2.Items.Add("Ja")
        cb_Wither2.Items.Add("Nein")
        cb_Wither2.Text = "Partikel"
        cb_Health_Boost2.Items.Remove("true")
        cb_Health_Boost2.Items.Remove("false")
        cb_Health_Boost2.Items.Add("Ja")
        cb_Health_Boost2.Items.Add("Nein")
        cb_Health_Boost2.Text = "Partikel"
        cb_Absorbtion2.Items.Remove("true")
        cb_Absorbtion2.Items.Remove("false")
        cb_Absorbtion2.Items.Add("Ja")
        cb_Absorbtion2.Items.Add("Nein")
        cb_Absorbtion2.Text = "Partikel"
        cb_Saturation2.Items.Remove("true")
        cb_Saturation2.Items.Remove("false")
        cb_Saturation2.Items.Add("Ja")
        cb_Saturation2.Items.Add("Nein")
        cb_Saturation2.Text = "Partikel"
        txt_Speed2.Text = "Stärke"
        txt_Slowness2.Text = "Stärke"
        txt_Haste2.Text = "Stärke"
        txt_Mining_Fatigue2.Text = "Stärke"
        txt_Strengh2.Text = "Stärke"
        txt_Instant_Health2.Text = "Stärke"
        txt_Instant_Damage2.Text = "Stärke"
        txt_Jump_Boost2.Text = "Stärke"
        txt_Nausea2.Text = "Stärke"
        txt_Regeneration2.Text = "Stärke"
        txt_Resistance2.Text = "Stärke"
        txt_Fire_Resistance2.Text = "Stärke"
        txt_Water_Breathing2.Text = "Stärke"
        txt_Invisibility2.Text = "Stärke"
        txt_Blindness2.Text = "Stärke"
        txt_Night_Vision2.Text = "Stärke"
        txt_Hunger2.Text = "Stärke"
        txt_Weakness2.Text = "Stärke"
        txt_Poison2.Text = "Stärke"
        txt_Wither2.Text = "Stärke"
        txt_Health_Boost2.Text = "Stärke"
        txt_Absorbtion2.Text = "Stärke"
        txt_Saturation2.Text = "Stärke"
        txt_Speed1.Text = "Dauer"
        txt_Slowness1.Text = "Dauer"
        txt_Haste1.Text = "Dauer"
        txt_Mining_Fatigue1.Text = "Dauer"
        txt_Strengh1.Text = "Dauer"
        txt_Instant_Health1.Text = "Dauer"
        txt_Instant_Damage1.Text = "Dauer"
        txt_Jump_Boost1.Text = "Dauer"
        txt_Nausea1.Text = "Dauer"
        txt_Regeneration1.Text = "Dauer"
        txt_Resistance1.Text = "Dauer"
        txt_Fire_Resistance1.Text = "Dauer"
        txt_Water_Breathing1.Text = "Dauer"
        txt_Invisibility1.Text = "Dauer"
        txt_Blindness1.Text = "Dauer"
        txt_Night_Vision1.Text = "Dauer"
        txt_Hunger1.Text = "Dauer"
        txt_Weakness1.Text = "Dauer"
        txt_Poison1.Text = "Dauer"
        txt_Wither1.Text = "Dauer"
        txt_Health_Boost1.Text = "Dauer"
        txt_Absorbtion1.Text = "Dauer"
        txt_Saturation1.Text = "Dauer"
        txt_Duration_All.Text = "Dauer"
        txt_Amplifier_All.Text = "Stärke"
        cb_Particles_All.Items.Remove("true")
        cb_Particles_All.Items.Remove("false")
        cb_Particles_All.Items.Add("Ja")
        cb_Particles_All.Items.Add("Nein")
        cb_Particles_All.Text = "Partikel"
        cb_All.Text = "Wert für Alle setzen"
        CheckBox1.Text = "Werfbarer Trank"
        LanguageToolStripMenuItem.Text = "Sprache"
        HelpToolStripMenuItem.Text = "Hilfe"
        FileToolStripMenuItem.Text = "Datei"
        SaveCommandToolStripMenuItem.Text = "Befehl speichern"
        CloseToolStripMenuItem.Text = "beenden"
        CreditsToolStripMenuItem.Text = "Ersteller"
        ToolStripMenuItem4.Text = "? "
        Button1.Text = "Extras hinzufügen"
        If Button1.Text = "Extras hinzufügen" Then
            Button1.Width = Button1.Width + 30
            Button2.Location = New Point(Button2.Location.X + 30, Button2.Location.Y)
        End If
        Button2.Text = "Kommando kopieren"
        Button2.Width = Button2.Width + 13
        CopyCommandToolStripMenuItem.Text = "Kommando kopieren"
    End Sub

    Private Sub EnglishToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EnglishToolStripMenuItem.Click
        cb_Speed1.Text = "Speed"
        cb_Slowness1.Text = "Slowness"
        cb_Haste1.Text = "Haste"
        cb_Mining_Fatigue1.Text = "Mining Fatigue"
        cb_Strengh1.Text = "Strengh"
        cb_Instant_Health1.Text = "Instant Health"
        cb_Instant_Damage1.Text = "Instant Damage"
        cb_Jump_Boost1.Text = "Jump Boost"
        cb_Nausea1.Text = "Nausea"
        'cb_Regeneration1.Text = "Regeneration"
        cb_Resistance1.Text = "Resistence"
        cb_Fire_Resistance1.Text = "Fireresistence"
        cb_Water_Breathing1.Text = "Water Breathing"
        cb_Invisibility1.Text = "Invisibility"
        cb_Blindness1.Text = "Blindness"
        cb_Night_Vision1.Text = "Night Vision"
        'cb_Hunger1.Text = "Hunger"
        cb_Weakness1.Text = "Weakness"
        cb_Poison1.Text = "Poison"
        'cb_Wither1.Text = "Wither"
        cb_Health_Boost1.Text = "Health Boost"
        'cb_Absorbtion1.Text = "Absorbtion"
        cb_Saturation1.Text = "Saturation"
        cb_Speed2.Items.Remove("Ja")
        cb_Speed2.Items.Remove("Nein")
        cb_Speed2.Items.Add("true")
        cb_Speed2.Items.Add("false")
        cb_Speed2.Text = "Particles"
        cb_Slowness2.Items.Remove("Ja")
        cb_Slowness2.Items.Remove("Nein")
        cb_Slowness2.Items.Add("true")
        cb_Slowness2.Items.Add("false")
        cb_Slowness2.Text = "Particles"
        cb_Haste2.Items.Remove("Ja")
        cb_Haste2.Items.Remove("Nein")
        cb_Haste2.Items.Add("true")
        cb_Haste2.Items.Add("false")
        cb_Haste2.Text = "Particles"
        cb_Mining_Fatigue2.Items.Remove("Ja")
        cb_Mining_Fatigue2.Items.Remove("Nein")
        cb_Mining_Fatigue2.Items.Add("true")
        cb_Mining_Fatigue2.Items.Add("false")
        cb_Mining_Fatigue2.Text = "Particles"
        cb_Strengh2.Items.Remove("Ja")
        cb_Strengh2.Items.Remove("Nein")
        cb_Strengh2.Items.Add("true")
        cb_Strengh2.Items.Add("false")
        cb_Strengh2.Text = "Particles"
        cb_Instant_Health2.Items.Remove("Ja")
        cb_Instant_Health2.Items.Remove("Nein")
        cb_Instant_Health2.Items.Add("true")
        cb_Instant_Health2.Items.Add("false")
        cb_Instant_Health2.Text = "Particles"
        cb_Instant_Damage2.Items.Remove("Ja")
        cb_Instant_Damage2.Items.Remove("Nein")
        cb_Instant_Damage2.Items.Add("true")
        cb_Instant_Damage2.Items.Add("false")
        cb_Instant_Damage2.Text = "Particles"
        cb_Jump_Boost2.Items.Remove("Ja")
        cb_Jump_Boost2.Items.Remove("Nein")
        cb_Jump_Boost2.Items.Add("true")
        cb_Jump_Boost2.Items.Add("false")
        cb_Jump_Boost2.Text = "Particles"
        cb_Nausea2.Items.Remove("Ja")
        cb_Nausea2.Items.Remove("Nein")
        cb_Nausea2.Items.Add("true")
        cb_Nausea2.Items.Add("false")
        cb_Nausea2.Text = "Particles"
        cb_Regeneration2.Items.Remove("Ja")
        cb_Regeneration2.Items.Remove("Nein")
        cb_Regeneration2.Items.Add("true")
        cb_Regeneration2.Items.Add("false")
        cb_Regeneration2.Text = "Particles"
        cb_Resistance2.Items.Remove("Ja")
        cb_Resistance2.Items.Remove("Nein")
        cb_Resistance2.Items.Add("true")
        cb_Resistance2.Items.Add("false")
        cb_Resistance2.Text = "Particles"
        cb_Fire_Resistance2.Items.Remove("Ja")
        cb_Fire_Resistance2.Items.Remove("Nein")
        cb_Fire_Resistance2.Items.Add("true")
        cb_Fire_Resistance2.Items.Add("false")
        cb_Fire_Resistance2.Text = "Particles"
        cb_Water_Breathing2.Items.Remove("Ja")
        cb_Water_Breathing2.Items.Remove("Nein")
        cb_Water_Breathing2.Items.Add("true")
        cb_Water_Breathing2.Items.Add("false")
        cb_Water_Breathing2.Text = "Particles"
        cb_Invisibility2.Items.Remove("Ja")
        cb_Invisibility2.Items.Remove("Nein")
        cb_Invisibility2.Items.Add("true")
        cb_Invisibility2.Items.Add("false")
        cb_Invisibility2.Text = "Particles"
        cb_Blindness2.Items.Remove("Ja")
        cb_Blindness2.Items.Remove("Nein")
        cb_Blindness2.Items.Add("true")
        cb_Blindness2.Items.Add("false")
        cb_Blindness2.Text = "Particles"
        cb_Night_Vision2.Items.Remove("Ja")
        cb_Night_Vision2.Items.Remove("Nein")
        cb_Night_Vision2.Items.Add("true")
        cb_Night_Vision2.Items.Add("false")
        cb_Night_Vision2.Text = "Particles"
        cb_Hunger2.Items.Remove("Ja")
        cb_Hunger2.Items.Remove("Nein")
        cb_Hunger2.Items.Add("true")
        cb_Hunger2.Items.Add("false")
        cb_Hunger2.Text = "Particles"
        cb_Weakness2.Items.Remove("Ja")
        cb_Weakness2.Items.Remove("Nein")
        cb_Weakness2.Items.Add("true")
        cb_Weakness2.Items.Add("false")
        cb_Weakness2.Text = "Particles"
        cb_Poison2.Items.Remove("Ja")
        cb_Poison2.Items.Remove("Nein")
        cb_Poison2.Items.Add("true")
        cb_Poison2.Items.Add("false")
        cb_Poison2.Text = "Particles"
        cb_Wither2.Items.Remove("Ja")
        cb_Wither2.Items.Remove("Nein")
        cb_Wither2.Items.Add("true")
        cb_Wither2.Items.Add("false")
        cb_Wither2.Text = "Particles"
        cb_Health_Boost2.Items.Remove("Ja")
        cb_Health_Boost2.Items.Remove("Nein")
        cb_Health_Boost2.Items.Add("true")
        cb_Health_Boost2.Items.Add("false")
        cb_Health_Boost2.Text = "Particles"
        cb_Absorbtion2.Items.Remove("Ja")
        cb_Absorbtion2.Items.Remove("Nein")
        cb_Absorbtion2.Items.Add("true")
        cb_Absorbtion2.Items.Add("false")
        cb_Absorbtion2.Text = "Particles"
        cb_Saturation2.Items.Remove("Ja")
        cb_Saturation2.Items.Remove("Nein")
        cb_Saturation2.Items.Add("true")
        cb_Saturation2.Items.Add("false")
        cb_Saturation2.Text = "Particles"
        txt_Speed2.Text = "Amplifier"
        txt_Slowness2.Text = "Amplifier"
        txt_Haste2.Text = "Amplifier"
        txt_Mining_Fatigue2.Text = "Amplifier"
        txt_Strengh2.Text = "Amplifier"
        txt_Instant_Health2.Text = "Amplifier"
        txt_Instant_Damage2.Text = "Amplifier"
        txt_Jump_Boost2.Text = "Amplifier"
        txt_Nausea2.Text = "Amplifier"
        txt_Regeneration2.Text = "Amplifier"
        txt_Resistance2.Text = "Amplifier"
        txt_Fire_Resistance2.Text = "Amplifier"
        txt_Water_Breathing2.Text = "Amplifier"
        txt_Invisibility2.Text = "Amplifier"
        txt_Blindness2.Text = "Amplifier"
        txt_Night_Vision2.Text = "Amplifier"
        txt_Hunger2.Text = "Amplifier"
        txt_Weakness2.Text = "Amplifier"
        txt_Poison2.Text = "Amplifier"
        txt_Wither2.Text = "Amplifier"
        txt_Health_Boost2.Text = "Amplifier"
        txt_Absorbtion2.Text = "Amplifier"
        txt_Saturation2.Text = "Amplifier"
        txt_Speed1.Text = "Duration"
        txt_Slowness1.Text = "Duration"
        txt_Haste1.Text = "Duration"
        txt_Mining_Fatigue1.Text = "Duration"
        txt_Strengh1.Text = "Duration"
        txt_Instant_Health1.Text = "Duration"
        txt_Instant_Damage1.Text = "Duration"
        txt_Jump_Boost1.Text = "Duration"
        txt_Nausea1.Text = "Duration"
        txt_Regeneration1.Text = "Duration"
        txt_Resistance1.Text = "Duration"
        txt_Fire_Resistance1.Text = "Duration"
        txt_Water_Breathing1.Text = "Duration"
        txt_Invisibility1.Text = "Duration"
        txt_Blindness1.Text = "Duration"
        txt_Night_Vision1.Text = "Duration"
        txt_Hunger1.Text = "Duration"
        txt_Weakness1.Text = "Duration"
        txt_Poison1.Text = "Duration"
        txt_Wither1.Text = "Duration"
        txt_Health_Boost1.Text = "Duration"
        txt_Absorbtion1.Text = "Duration"
        txt_Saturation1.Text = "Duration"
        cb_All.Text = "Set Value for all"
        LanguageToolStripMenuItem.Text = "Language"
        HelpToolStripMenuItem.Text = "Help"
        FileToolStripMenuItem.Text = "File"
        SaveCommandToolStripMenuItem.Text = "Save Command"
        CloseToolStripMenuItem.Text = "Close"
        CreditsToolStripMenuItem.Text = "Credits"
        ToolStripMenuItem4.Text = "?"
        Button1.Text = "Add Extras"
        If Button1.Text = "Add Extras" Then
            Button1.Width = Button1.Width - 30
            Button2.Location = New Point(Button2.Location.X - 30, Button2.Location.Y)
        End If
        Button2.Text = "copy command"
        Button2.Width = Button2.Width - 13
        CopyCommandToolStripMenuItem.Text = "copy command"
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        System.IO.File.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Settings_enabled_off()
        cb_Speed2.Enabled = False
        cb_Slowness2.Enabled = False
        cb_Haste2.Enabled = False
        cb_Mining_Fatigue2.Enabled = False
        cb_Strengh2.Enabled = False
        cb_Instant_Health2.Enabled = False
        cb_Instant_Damage2.Enabled = False
        cb_Jump_Boost2.Enabled = False
        cb_Nausea2.Enabled = False
        cb_Regeneration2.Enabled = False
        cb_Resistance2.Enabled = False
        cb_Fire_Resistance2.Enabled = False
        cb_Water_Breathing2.Enabled = False
        cb_Invisibility2.Enabled = False
        cb_Blindness2.Enabled = False
        cb_Night_Vision2.Enabled = False
        cb_Hunger2.Enabled = False
        cb_Weakness2.Enabled = False
        cb_Poison2.Enabled = False
        cb_Wither2.Enabled = False
        cb_Health_Boost2.Enabled = False
        cb_Absorbtion2.Enabled = False
        cb_Saturation2.Enabled = False
        txt_Speed1.Enabled = False
        txt_Speed2.Enabled = False
        txt_Slowness1.Enabled = False
        txt_Slowness2.Enabled = False
        txt_Haste1.Enabled = False
        txt_Haste2.Enabled = False
        txt_Mining_Fatigue1.Enabled = False
        txt_Mining_Fatigue2.Enabled = False
        txt_Strengh1.Enabled = False
        txt_Strengh2.Enabled = False
        txt_Instant_Health1.Enabled = False
        txt_Instant_Health2.Enabled = False
        txt_Instant_Damage1.Enabled = False
        txt_Instant_Damage2.Enabled = False
        txt_Jump_Boost1.Enabled = False
        txt_Jump_Boost2.Enabled = False
        txt_Nausea1.Enabled = False
        txt_Nausea2.Enabled = False
        txt_Regeneration1.Enabled = False
        txt_Regeneration2.Enabled = False
        txt_Resistance1.Enabled = False
        txt_Resistance2.Enabled = False
        txt_Fire_Resistance1.Enabled = False
        txt_Fire_Resistance2.Enabled = False
        txt_Water_Breathing1.Enabled = False
        txt_Water_Breathing2.Enabled = False
        txt_Invisibility1.Enabled = False
        txt_Invisibility2.Enabled = False
        txt_Blindness1.Enabled = False
        txt_Blindness2.Enabled = False
        txt_Night_Vision1.Enabled = False
        txt_Night_Vision2.Enabled = False
        txt_Hunger1.Enabled = False
        txt_Hunger2.Enabled = False
        txt_Weakness1.Enabled = False
        txt_Weakness2.Enabled = False
        txt_Poison1.Enabled = False
        txt_Poison2.Enabled = False
        txt_Wither1.Enabled = False
        txt_Wither2.Enabled = False
        txt_Health_Boost1.Enabled = False
        txt_Health_Boost2.Enabled = False
        txt_Absorbtion1.Enabled = False
        txt_Absorbtion2.Enabled = False
        txt_Saturation1.Enabled = False
        txt_Saturation2.Enabled = False
    End Sub

    Private Sub Settings_enabled_on()
        cb_Speed2.Enabled = True
        cb_Slowness2.Enabled = True
        cb_Haste2.Enabled = True
        cb_Mining_Fatigue2.Enabled = True
        cb_Strengh2.Enabled = True
        cb_Instant_Health2.Enabled = True
        cb_Instant_Damage2.Enabled = True
        cb_Jump_Boost2.Enabled = True
        cb_Nausea2.Enabled = True
        cb_Regeneration2.Enabled = True
        cb_Resistance2.Enabled = True
        cb_Fire_Resistance2.Enabled = True
        cb_Water_Breathing2.Enabled = True
        cb_Invisibility2.Enabled = True
        cb_Blindness2.Enabled = True
        cb_Night_Vision2.Enabled = True
        cb_Hunger2.Enabled = True
        cb_Weakness2.Enabled = True
        cb_Poison2.Enabled = True
        cb_Wither2.Enabled = True
        cb_Health_Boost2.Enabled = True
        cb_Absorbtion2.Enabled = True
        cb_Saturation2.Enabled = True
        txt_Speed1.Enabled = True
        txt_Speed2.Enabled = True
        txt_Slowness1.Enabled = True
        txt_Slowness2.Enabled = True
        txt_Haste1.Enabled = True
        txt_Haste2.Enabled = True
        txt_Mining_Fatigue1.Enabled = True
        txt_Mining_Fatigue2.Enabled = True
        txt_Strengh1.Enabled = True
        txt_Strengh2.Enabled = True
        txt_Instant_Health1.Enabled = True
        txt_Instant_Health2.Enabled = True
        txt_Instant_Damage1.Enabled = True
        txt_Instant_Damage2.Enabled = True
        txt_Jump_Boost1.Enabled = True
        txt_Jump_Boost2.Enabled = True
        txt_Nausea1.Enabled = True
        txt_Nausea2.Enabled = True
        txt_Regeneration1.Enabled = True
        txt_Regeneration2.Enabled = True
        txt_Resistance1.Enabled = True
        txt_Resistance2.Enabled = True
        txt_Fire_Resistance1.Enabled = True
        txt_Fire_Resistance2.Enabled = True
        txt_Water_Breathing1.Enabled = True
        txt_Water_Breathing2.Enabled = True
        txt_Invisibility1.Enabled = True
        txt_Invisibility2.Enabled = True
        txt_Blindness1.Enabled = True
        txt_Blindness2.Enabled = True
        txt_Night_Vision1.Enabled = True
        txt_Night_Vision2.Enabled = True
        txt_Hunger1.Enabled = True
        txt_Hunger2.Enabled = True
        txt_Weakness1.Enabled = True
        txt_Weakness2.Enabled = True
        txt_Poison1.Enabled = True
        txt_Poison2.Enabled = True
        txt_Wither1.Enabled = True
        txt_Wither2.Enabled = True
        txt_Health_Boost1.Enabled = True
        txt_Health_Boost2.Enabled = True
        txt_Absorbtion1.Enabled = True
        txt_Absorbtion2.Enabled = True
        txt_Saturation1.Enabled = True
        txt_Saturation2.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            My.Computer.Clipboard.SetText(TextBox1.Text)
        Catch ex As Exception
            MsgBox("Bitte generieren Sie zuerst einen Code" & vbCrLf & vbCrLf & "Please generate a Code first", MsgBoxStyle.Critical, "kein Code|no Code")
        End Try
    End Sub

    Private Sub CopyCommandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyCommandToolStripMenuItem.Click
        Button2.PerformClick()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Back : TextBox1.Text = ""
        End Select
    End Sub
End Class