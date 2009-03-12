﻿using TaikodomStats.DataSL;
namespace TaikodomStats.DataSL
{
    public static class InstanciateData
    {
        public static Career[] GetCareers(bool pt)
        {
            if (pt)
            {
                #region Career base

                var hotShot = new Career("Ás", 69);
                var batedor = new Career("Explorador", 69);
                var bomber = new Career("Demolidor", 69);
                var cargueiro = new Career("Mercador", 69);

                #endregion

                #region skill base

                var pilotagem = new Skill("Pilotagem");
                var afterburn = new Skill("Afterburn");
                var canhoneiro = new Skill("Canhoneiro");
                var escudoSuperior = new Skill("Escudo Superior");
                var misseis = new Skill("Demolição : Mísseis");
                var foguetes = new Skill("Demolição : Foguetes");
                var rail = new Skill("Artilharia : Rail");
                var gaus = new Skill("Artilharia : Gauss");
                var particulas = new Skill("Artilharia : Partículas");
                var magnetica = new Skill("Artilharia : Magnética");
                var balistica = new Skill("Artilharia : Balística");
                var plasma = new Skill("Artilharia : Plasma");
                var scatter = new Skill("Artilharia : Scatter");
                var neutron = new Skill("Artilharia : Neutron");
                var emboscar = new Skill("Emboscar");
                var blaster = new Skill("Artilharia : Blaster");
                var gerenciamento = new Skill("Gerenciamento Energético");
                var antiradiacao = new Skill("Anti-Radiação");
                var mina = new Skill("Demolição : Minas");
                var otimizacao = new Skill("Otimização de Conteiner");
                var cofre = new Skill("Cofre");
                var especialista = new Skill("Especialista em Minas");
                var casco = new Skill("Casco Superior");
                var omega = new Skill("OmegaStrike");
                var especdemoli = new Skill("Especialista em Demolição");
                var torpedo = new Skill("Demolição : Torpedos");

                #endregion

                #region hotshot base

                hotShot.AddSkillPoint(pilotagem, 1, "Habilita Caça Básico", true, null);
                hotShot.AddSkillPoint(pilotagem, 2, "+ 3% Escudo, 2% Aceleração, 1% Velocidade", false, null);
                hotShot.AddSkillPoint(pilotagem, 3, "+ 3% Escudo, 2% Aceleração, 1% Velocidade", false, null);
                hotShot.AddSkillPoint(pilotagem, 4, "+ 3% Escudo, 2% Aceleração, 1% Velocidade", false, null);
                hotShot.AddSkillPoint(pilotagem, 5, "+ 3% Escudo, 2% Aceleração, 1% Velocidade", false, null);
                hotShot.AddSkillPoint(pilotagem, 6, "+ 3% Escudo, 2% Aceleração, 1% Velocidade", false, null);
                hotShot.AddSkillPoint(pilotagem, 7, "+ 3% Escudo, 2% Aceleração, 1% Velocidade", false, null);
                hotShot.AddSkillPoint(pilotagem, 8, "Habilita Caça Intermediário", false, 15);
                hotShot.AddSkillPoint(pilotagem, 9, "+ 3% Escudo, 2% Aceleração, 1% Velocidade", false, null);
                hotShot.AddSkillPoint(pilotagem, 10, "+ 3% Escudo, 2% Aceleração, 1% Velocidade", false, null);
                hotShot.AddSkillPoint(pilotagem, 11, "+ 3% Escudo, 2% Aceleração, 1% Velocidade", false, null);
                hotShot.AddSkillPoint(pilotagem, 12, "+ 3% Escudo, 2% Aceleração, 1% Velocidade", false, null);
                hotShot.AddSkillPoint(pilotagem, 13, "+ 3% Escudo, 2% Aceleração, 1% Velocidade", false, null);
                hotShot.AddSkillPoint(pilotagem, 14, "+ 3% Escudo, 2% Aceleração, 1% Velocidade", false, null);
                hotShot.AddSkillPoint(pilotagem, 15, "Habilita Caça Avançado", false, 40);

                hotShot.AddSkillPoint(gaus, 1, "Habilita Gauss Básico", true, null);
                hotShot.AddSkillPoint(gaus, 2, "+ 3% Cadência, 3% velocidade projétil", false, null);
                hotShot.AddSkillPoint(gaus, 3, "+ 3% Cadência, 3% velocidade projétil", false, null);
                hotShot.AddSkillPoint(gaus, 4, "+ 3% Cadência, 3% velocidade projétil", false, null);
                hotShot.AddSkillPoint(gaus, 5, "Habilita Gauss Duplo", false, null);
                hotShot.AddSkillPoint(gaus, 6, "+ 3% Cadência, 3% velocidade projétil", false, null);
                hotShot.AddSkillPoint(gaus, 7, "+ 3% Cadência, 3% velocidade projétil", false, null);
                hotShot.AddSkillPoint(gaus, 8, "+ 3% Cadência, 3% velocidade projétil", false, null);
                hotShot.AddSkillPoint(gaus, 9, "+ 3% Cadência, 3% velocidade projétil", false, null);
                hotShot.AddSkillPoint(gaus, 10, "Habilita Gauss Avançado", false, null);

                hotShot.AddSkillPoint(magnetica, 1, "Habilita Magnético Básico", true, null);
                hotShot.AddSkillPoint(magnetica, 2, "+ 3% Cadência, 3% velocidade projétil", false, null);
                hotShot.AddSkillPoint(magnetica, 3, "+ 3% Cadência, 3% velocidade projétil", false, null);
                hotShot.AddSkillPoint(magnetica, 4, "+ 3% Cadência, 3% velocidade projétil", false, null);
                hotShot.AddSkillPoint(magnetica, 5, "Habilita Magnético Duplo", false, null);
                hotShot.AddSkillPoint(magnetica, 6, "+ 3% Cadência, 3% velocidade projétil", false, null);
                hotShot.AddSkillPoint(magnetica, 7, "+ 3% Cadência, 3% velocidade projétil", false, null);
                hotShot.AddSkillPoint(magnetica, 8, "+ 3% Cadência, 3% velocidade projétil", false, null);
                hotShot.AddSkillPoint(magnetica, 9, "+ 3% Cadência, 3% velocidade projétil", false, null);
                hotShot.AddSkillPoint(magnetica, 10, "Habilita Magnético Avançado", false, null);

                hotShot.AddSkillPoint(afterburn, 1, "+ 2% Velocidade, 1 segundo duração", false, null);
                hotShot.AddSkillPoint(afterburn, 2, "+ 2% Velocidade, 1 segundo duração", false, null);
                hotShot.AddSkillPoint(afterburn, 3, "+ 2% Velocidade, 1 segundo duração", false, null);
                hotShot.AddSkillPoint(afterburn, 4, "+ 2% Velocidade, 1 segundo duração", false, null);
                hotShot.AddSkillPoint(afterburn, 5, "+ 2% Velocidade, 1 segundo duração", false, null);

                hotShot.AddSkillPoint(rail, 1, "Habilita Rail Básico", false, null);
                hotShot.AddSkillPoint(rail, 2, "+ 3% Dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(rail, 3, "+ 3% Dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(rail, 4, "+ 3% Dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(rail, 5, "Habilita Rail Duplo", false, null);
                hotShot.AddSkillPoint(rail, 6, "+ 3% Dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(rail, 7, "+ 3% Dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(rail, 8, "+ 3% Dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(rail, 9, "+ 3% Dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(rail, 10, "Habilita Rail Avançado", false, null);

                hotShot.AddSkillPoint(particulas, 1, "Habilita Partículas Básico", false, null);
                hotShot.AddSkillPoint(particulas, 2, "+ 3% Dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(particulas, 3, "+ 3% Dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(particulas, 4, "+ 3% Dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(particulas, 5, "Habilita Partículas Duplo", false, null);
                hotShot.AddSkillPoint(particulas, 6, "+ 3% Dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(particulas, 7, "+ 3% Dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(particulas, 8, "+ 3% Dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(particulas, 9, "+ 3% Dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(particulas, 10, "Habilita Partículas Avançado", false, null);

                hotShot.AddSkillPoint(escudoSuperior, 1, "+ 5% escudo, 4 regeneração", false, 40);
                hotShot.AddSkillPoint(escudoSuperior, 2, "+ 5% escudo, 4 regeneração", false, 40);
                hotShot.AddSkillPoint(escudoSuperior, 3, "+ 5% escudo, 4 regeneração", false, 40);
                hotShot.AddSkillPoint(escudoSuperior, 4, "+ 5% escudo, 4 regeneração", false, 40);
                hotShot.AddSkillPoint(escudoSuperior, 5, "+ 5% escudo, 4 regeneração", false, 40);

                hotShot.AddSkillPoint(canhoneiro, 1, "+ 3% dano", false, 40);
                hotShot.AddSkillPoint(canhoneiro, 2, "+ 3% dano", false, 40);
                hotShot.AddSkillPoint(canhoneiro, 3, "+ 3% dano", false, 40);
                hotShot.AddSkillPoint(canhoneiro, 4, "+ 3% dano", false, 40);
                hotShot.AddSkillPoint(canhoneiro, 5, "+ 3% dano", false, 40);

                hotShot.AddSkillPoint(misseis, 1, "Habilita Lançador categoria Míssel Leve", false, null);
                hotShot.AddSkillPoint(misseis, 2, "+ 5% alcance, 3% cadência", false, null);
                hotShot.AddSkillPoint(misseis, 3, "+ 5% alcance, 3% cadência", false, null);
                hotShot.AddSkillPoint(misseis, 4, "+ 5% alcance, 3% cadência", false, null);
                hotShot.AddSkillPoint(misseis, 5, "+ 5% alcance, 3% cadência", false, null);

                hotShot.AddSkillPoint(foguetes, 1, "Habilita Lançador categoria Foguete", false, null);
                hotShot.AddSkillPoint(foguetes, 2, "+ 2% dano", false, null);
                hotShot.AddSkillPoint(foguetes, 3, "+ 2% dano", false, null);
                hotShot.AddSkillPoint(foguetes, 4, "+ 2% dano", false, null);
                hotShot.AddSkillPoint(foguetes, 5, "+ 2% dano", false, null);

                hotShot.AddSkillPoint(balistica, 1, "Habilita Balístico Básico", false, 25);
                hotShot.AddSkillPoint(balistica, 2, "+ 3% dano, 3% cadência", false, null);
                hotShot.AddSkillPoint(balistica, 3, "+ 3% dano, 3% cadência", false, null);
                hotShot.AddSkillPoint(balistica, 4, "+ 3% dano, 3% cadência", false, null);
                hotShot.AddSkillPoint(balistica, 5, "Habilita Balístico Duplo", false, 40);
                hotShot.AddSkillPoint(balistica, 6, "+ 3% dano, 3% cadência", false, null);
                hotShot.AddSkillPoint(balistica, 7, "+ 3% dano, 3% cadência", false, null);
                hotShot.AddSkillPoint(balistica, 8, "+ 3% dano, 3% cadência", false, null);
                hotShot.AddSkillPoint(balistica, 9, "+ 3% dano, 3% cadência", false, null);
                hotShot.AddSkillPoint(balistica, 10, "Habilita Balístico Avançado", false, 50);

                hotShot.AddSkillPoint(plasma, 1, "Habilita Plasma Básico", false, 25);
                hotShot.AddSkillPoint(plasma, 2, "+ 2% dano, 4% cadência", false, null);
                hotShot.AddSkillPoint(plasma, 3, "+ 2% dano, 4% cadência", false, null);
                hotShot.AddSkillPoint(plasma, 4, "+ 2% dano, 4% cadência", false, null);
                hotShot.AddSkillPoint(plasma, 5, "Habilita Plasma Duplo", false, 40);
                hotShot.AddSkillPoint(plasma, 6, "+ 2% dano, 4% cadência", false, null);
                hotShot.AddSkillPoint(plasma, 7, "+ 2% dano, 4% cadência", false, null);
                hotShot.AddSkillPoint(plasma, 8, "+ 2% dano, 4% cadência", false, null);
                hotShot.AddSkillPoint(plasma, 9, "+ 2% dano, 4% cadência", false, null);
                hotShot.AddSkillPoint(plasma, 10, "Habilita Plasma Avançado", false, 50);

                hotShot.AddSkillPoint(blaster, 1, "Habilita Blaster Básico", false, null);
                hotShot.AddSkillPoint(blaster, 2, "+ 3% dano, 4% velocidade projétil", false, null);
                hotShot.AddSkillPoint(blaster, 3, "+ 3% dano, 4% velocidade projétil", false, null);
                hotShot.AddSkillPoint(blaster, 4, "+ 3% dano, 4% velocidade projétil", false, null);
                hotShot.AddSkillPoint(blaster, 5, "Habilita Blaster Duplo", false, null);
                hotShot.AddSkillPoint(blaster, 6, "+ 3% dano, 4% velocidade projétil", false, null);
                hotShot.AddSkillPoint(blaster, 7, "+ 3% dano, 4% velocidade projétil", false, null);
                hotShot.AddSkillPoint(blaster, 8, "+ 3% dano, 4% velocidade projétil", false, null);
                hotShot.AddSkillPoint(blaster, 9, "+ 3% dano, 4% velocidade projétil", false, null);
                hotShot.AddSkillPoint(blaster, 10, "Habilita Blaster Avançado", false, null);

                hotShot.AddSkillPoint(neutron, 1, "Habilita Neutron Básico", false, null);
                hotShot.AddSkillPoint(neutron, 2, "+ 2% dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(neutron, 3, "+ 2% dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(neutron, 4, "+ 2% dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(neutron, 5, "Habilita Neutron Duplo", false, null);
                hotShot.AddSkillPoint(neutron, 6, "+ 2% dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(neutron, 7, "+ 2% dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(neutron, 8, "+ 2% dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(neutron, 9, "+ 2% dano, 3% alcance", false, null);
                hotShot.AddSkillPoint(neutron, 10, "Habilita Neutron Avançado", false, null);

                hotShot.AddSkillPoint(scatter, 1, "Habilita Scatter Básico", false, null);
                hotShot.AddSkillPoint(scatter, 2, "+ 3% dano, 3% cadência", false, null);
                hotShot.AddSkillPoint(scatter, 3, "+ 3% dano, 3% cadência", false, null);
                hotShot.AddSkillPoint(scatter, 4, "+ 3% dano, 3% cadência", false, null);
                hotShot.AddSkillPoint(scatter, 5, "Habilita Scatter Duplo", false, null);
                hotShot.AddSkillPoint(scatter, 6, "+ 3% dano, 3% cadência", false, null);
                hotShot.AddSkillPoint(scatter, 7, "+ 3% dano, 3% cadência", false, null);
                hotShot.AddSkillPoint(scatter, 8, "+ 3% dano, 3% cadência", false, null);
                hotShot.AddSkillPoint(scatter, 9, "+ 3% dano, 3% cadência", false, null);
                hotShot.AddSkillPoint(scatter, 10, "Habilita Scatter Avançado", false, null);

                #endregion

                #region scoult base

                batedor.AddSkillPoint(pilotagem, 1, "Habilita Explorador Básico", true, null);
                batedor.AddSkillPoint(pilotagem, 2, "+ 3% velocidade, 2% cruzeiro, 1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 3, "+ 3% velocidade, 2% cruzeiro, 1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 4, "+ 3% velocidade, 2% cruzeiro, +1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 5, "+ 3% velocidade, 2% cruzeiro, +1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 6, "+ 3% velocidade, 2% cruzeiro, +1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 7, "+ 3% velocidade, 2% cruzeiro, +1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 8, "+Habilita Explorador Intermediário", false, null);
                batedor.AddSkillPoint(pilotagem, 9, "+ 3% velocidade, 2% cruzeiro, 1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 10, "+ 3% velocidade, 2% cruzeiro, 1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 11, "+ 3% velocidade, 2% cruzeiro, 1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 12, "+ 3% velocidade, 2% cruzeiro, 1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 13, "+ 3% velocidade, 2% cruzeiro, 1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 14, "+ 3% velocidade, 2% cruzeiro, 1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 15, "Habilita Explorador Avançado", false, null);

                batedor.AddSkillPoint(particulas, 1, "Habilita Partículas Básico", true, null);
                batedor.AddSkillPoint(particulas, 2, "+ 3% Dano, 3% alcance", false, null);
                batedor.AddSkillPoint(particulas, 3, "+ 3% Dano, 3% alcance", false, null);
                batedor.AddSkillPoint(particulas, 4, "+ 3% Dano, 3% alcance", false, null);
                batedor.AddSkillPoint(particulas, 5, "Habilita Partículas Duplo", false, null);
                batedor.AddSkillPoint(particulas, 6, "+ 3% Dano, 3% alcance", false, null);
                batedor.AddSkillPoint(particulas, 7, "+ 3% Dano, 3% alcance", false, null);
                batedor.AddSkillPoint(particulas, 8, "+ 3% Dano, 3% alcance", false, null);
                batedor.AddSkillPoint(particulas, 9, "+ 3% Dano, 3% alcance", false, null);
                batedor.AddSkillPoint(particulas, 10, "Habilita Partículas Avançado", false, null);

                batedor.AddSkillPoint(gerenciamento, 1, "- 0,2% tempo de ativação do cruzeiro", true, null);
                batedor.AddSkillPoint(gerenciamento, 2, "- 0,2% tempo de ativação do cruzeiro", false, null);
                batedor.AddSkillPoint(gerenciamento, 3, "- 0,2% tempo de ativação do cruzeiro", false, null);
                batedor.AddSkillPoint(gerenciamento, 4, "- 0,2% tempo de ativação do cruzeiro", false, null);
                batedor.AddSkillPoint(gerenciamento, 5, "- 0,2% tempo de ativação do cruzeiro", false, null);
                batedor.AddSkillPoint(gerenciamento, 6, "- 0,2% tempo de ativação do cruzeiro", false, null);
                batedor.AddSkillPoint(gerenciamento, 7, "- 0,2% tempo de ativação do cruzeiro", false, null);
                batedor.AddSkillPoint(gerenciamento, 8, "- 0,2% tempo de ativação do cruzeiro", false, null);
                batedor.AddSkillPoint(gerenciamento, 9, "- 0,2% tempo de ativação do cruzeiro", false, null);
                batedor.AddSkillPoint(gerenciamento, 10, "- 0,2% tempo de ativação do cruzeiro", false, null);

                batedor.AddSkillPoint(antiradiacao, 1, "-10% custo de ativação", false, null);
                batedor.AddSkillPoint(antiradiacao, 2, "-10% custo de ativação", false, null);
                batedor.AddSkillPoint(antiradiacao, 3, "-10% custo de ativação", false, null);
                batedor.AddSkillPoint(antiradiacao, 4, "-10% custo de ativação", false, null);
                batedor.AddSkillPoint(antiradiacao, 5, "-10% custo de ativação", false, null);

                batedor.AddSkillPoint(gaus, 1, "Habilita Gauss Básico", false, null);
                batedor.AddSkillPoint(gaus, 2, "+ 3% Cadência, 3% velocidade projétil", false, null);
                batedor.AddSkillPoint(gaus, 3, "+ 3% Cadência, 3% velocidade projétil", false, null);
                batedor.AddSkillPoint(gaus, 4, "+ 3% Cadência, 3% velocidade projétil", false, null);
                batedor.AddSkillPoint(gaus, 5, "Habilita Gauss Duplo", false, null);
                batedor.AddSkillPoint(gaus, 6, "+ 3% Cadência, 3% velocidade projétil", false, null);
                batedor.AddSkillPoint(gaus, 7, "+ 3% Cadência, 3% velocidade projétil", false, null);
                batedor.AddSkillPoint(gaus, 8, "+ 3% Cadência, 3% velocidade projétil", false, null);
                batedor.AddSkillPoint(gaus, 9, "+ 3% Cadência, 3% velocidade projétil", false, null);
                batedor.AddSkillPoint(gaus, 10, "Habilita Gauss Avançado", false, null);

                batedor.AddSkillPoint(neutron, 1, "Habilita Neutron Básico", false, null);
                batedor.AddSkillPoint(neutron, 2, "+ 2% dano, 3% alcance", false, null);
                batedor.AddSkillPoint(neutron, 3, "+ 2% dano, 3% alcance", false, null);
                batedor.AddSkillPoint(neutron, 4, "+ 2% dano, 3% alcance", false, null);
                batedor.AddSkillPoint(neutron, 5, "Habilita Neutron Duplo", false, null);
                batedor.AddSkillPoint(neutron, 6, "+ 2% dano, 3% alcance", false, null);
                batedor.AddSkillPoint(neutron, 7, "+ 2% dano, 3% alcance", false, null);
                batedor.AddSkillPoint(neutron, 8, "+ 2% dano, 3% alcance", false, null);
                batedor.AddSkillPoint(neutron, 9, "+ 2% dano, 3% alcance", false, null);
                batedor.AddSkillPoint(neutron, 10, "Habilita Neutron Avançado", false, null);

                batedor.AddSkillPoint(blaster, 1, "Habilita Blaster Básico", false, null);
                batedor.AddSkillPoint(blaster, 2, "+ 3% dano, 4% velocidade projétil", false, null);
                batedor.AddSkillPoint(blaster, 3, "+ 3% dano, 4% velocidade projétil", false, null);
                batedor.AddSkillPoint(blaster, 4, "+ 3% dano, 4% velocidade projétil", false, null);
                batedor.AddSkillPoint(blaster, 5, "Habilita Blaster Duplo", false, null);
                batedor.AddSkillPoint(blaster, 6, "+ 3% dano, 4% velocidade projétil", false, null);
                batedor.AddSkillPoint(blaster, 7, "+ 3% dano, 4% velocidade projétil", false, null);
                batedor.AddSkillPoint(blaster, 8, "+ 3% dano, 4% velocidade projétil", false, null);
                batedor.AddSkillPoint(blaster, 9, "+ 3% dano, 4% velocidade projétil", false, null);
                batedor.AddSkillPoint(blaster, 10, "Habilita Blaster Avançado", false, null);

                batedor.AddSkillPoint(misseis, 1, "Habilita Lançador Categoria Míssel Leve", false, null);
                batedor.AddSkillPoint(misseis, 2, "+ 5% alcance, 3% cadência", false, null);
                batedor.AddSkillPoint(misseis, 3, "+ 5% alcance, 3% cadência", false, null);
                batedor.AddSkillPoint(misseis, 4, "+ 5% alcance, 3% cadência", false, null);
                batedor.AddSkillPoint(misseis, 5, "+ 5% alcance, 3% cadência", false, null);

                batedor.AddSkillPoint(mina, 1, "Habilita Lançador Categoria Mina Leve", false, null);
                batedor.AddSkillPoint(mina, 2, "+ 5% dano", false, null);
                batedor.AddSkillPoint(mina, 3, "+ 5% dano", false, null);
                batedor.AddSkillPoint(mina, 4, "+ 5% dano", false, null);
                batedor.AddSkillPoint(mina, 5, "Habilita Lançador Categoria Mina Média", false, null);

                batedor.AddSkillPoint(otimizacao, 1, "+ 2% container", false, null);
                batedor.AddSkillPoint(otimizacao, 2, "+ 2% container", false, null);
                batedor.AddSkillPoint(otimizacao, 3, "+ 2% container", false, null);
                batedor.AddSkillPoint(otimizacao, 4, "+ 2% container", false, null);
                batedor.AddSkillPoint(otimizacao, 5, "+ 2% container", false, null);

                batedor.AddSkillPoint(rail, 1, "Habilita Rail Básico", false, null);
                batedor.AddSkillPoint(rail, 2, "+ 3% Dano, 3% alcance", false, null);
                batedor.AddSkillPoint(rail, 3, "+ 3% Dano, 3% alcance", false, null);
                batedor.AddSkillPoint(rail, 4, "+ 3% Dano, 3% alcance", false, null);
                batedor.AddSkillPoint(rail, 5, "Habilita Rail Duplo", false, null);
                batedor.AddSkillPoint(rail, 6, "+ 3% Dano, 3% alcance", false, null);
                batedor.AddSkillPoint(rail, 7, "+ 3% Dano, 3% alcance", false, null);
                batedor.AddSkillPoint(rail, 8, "+ 3% Dano, 3% alcance", false, null);
                batedor.AddSkillPoint(rail, 9, "+ 3% Dano, 3% alcance", false, null);
                batedor.AddSkillPoint(rail, 10, "Habilita Rail Avançado", false, null);

                batedor.AddSkillPoint(escudoSuperior, 1, "+ 5% escudo, 4 regeneração", false, null);
                batedor.AddSkillPoint(escudoSuperior, 2, "+ 5% escudo, 4 regeneração", false, null);
                batedor.AddSkillPoint(escudoSuperior, 3, "+ 5% escudo, 4 regeneração", false, null);
                batedor.AddSkillPoint(escudoSuperior, 4, "+ 5% escudo, 4 regeneração", false, null);
                batedor.AddSkillPoint(escudoSuperior, 5, "+ 5% escudo, 4 regeneração", false, null);

                batedor.AddSkillPoint(emboscar, 1, "+ 3% alcançe", false, null);
                batedor.AddSkillPoint(emboscar, 2, "+ 3% alcançe", false, null);
                batedor.AddSkillPoint(emboscar, 3, "+ 3% alcançe", false, null);
                batedor.AddSkillPoint(emboscar, 4, "+ 3% alcançe", false, null);
                batedor.AddSkillPoint(emboscar, 5, "+ 3% alcançe", false, null);

                #endregion

                #region merchant base

                cargueiro.AddSkillPoint(pilotagem, 1, "Habilita Mercador básico", true, null);
                cargueiro.AddSkillPoint(pilotagem, 2, "+ 3% casco, 2% container, 1% cruzeiro", false, null);
                cargueiro.AddSkillPoint(pilotagem, 3, "+ 3% casco, 2% container, 1% cruzeiro", false, null);
                cargueiro.AddSkillPoint(pilotagem, 4, "+ 3% casco, 2% container, 1% cruzeiro", false, null);
                cargueiro.AddSkillPoint(pilotagem, 5, "+ 3% casco, 2% container, 1% cruzeiro", false, null);
                cargueiro.AddSkillPoint(pilotagem, 6, "+ 3% casco, 2% container, 1% cruzeiro", false, null);
                cargueiro.AddSkillPoint(pilotagem, 7, "+ 3% casco, 2% container, 1% cruzeiro", false, null);
                cargueiro.AddSkillPoint(pilotagem, 8, "+Habilita Mercador Intermediário", false, null);
                cargueiro.AddSkillPoint(pilotagem, 9, "+ 3% casco, 2% container, 1% cruzeiro", false, null);
                cargueiro.AddSkillPoint(pilotagem, 10, "+ 3% casco, 2% container, 1% cruzeiro", false, null);
                cargueiro.AddSkillPoint(pilotagem, 11, "+ 3% casco, 2% container, 1% cruzeiro", false, null);
                cargueiro.AddSkillPoint(pilotagem, 12, "+ 3% casco, 2% container, 1% cruzeiro", false, null);
                cargueiro.AddSkillPoint(pilotagem, 13, "+ 3% casco, 2% container, 1% cruzeiro", false, null);
                cargueiro.AddSkillPoint(pilotagem, 14, "+ 3% casco, 2% container, 1% cruzeiro", false, null);
                cargueiro.AddSkillPoint(pilotagem, 15, "Habilita Mercador Avançado", false, null);

                cargueiro.AddSkillPoint(gerenciamento, 1, "- 0,2% tempo de ativação do cruzeiro", true, null);
                cargueiro.AddSkillPoint(gerenciamento, 2, "- 0,2% tempo de ativação do cruzeiro", false, null);
                cargueiro.AddSkillPoint(gerenciamento, 3, "- 0,2% tempo de ativação do cruzeiro", false, null);
                cargueiro.AddSkillPoint(gerenciamento, 4, "- 0,2% tempo de ativação do cruzeiro", false, null);
                cargueiro.AddSkillPoint(gerenciamento, 5, "- 0,2% tempo de ativação do cruzeiro", false, null);
                cargueiro.AddSkillPoint(gerenciamento, 6, "- 0,2% tempo de ativação do cruzeiro", false, null);
                cargueiro.AddSkillPoint(gerenciamento, 7, "- 0,2% tempo de ativação do cruzeiro", false, null);
                cargueiro.AddSkillPoint(gerenciamento, 8, "- 0,2% tempo de ativação do cruzeiro", false, null);
                cargueiro.AddSkillPoint(gerenciamento, 9, "- 0,2% tempo de ativação do cruzeiro", false, null);
                cargueiro.AddSkillPoint(gerenciamento, 10, "- 0,2% tempo de ativação do cruzeiro", false, null);

                cargueiro.AddSkillPoint(particulas, 1, "Habilita Partículas Básico", true, null);
                cargueiro.AddSkillPoint(particulas, 2, "+ 3% Dano, 3% alcance", false, null);
                cargueiro.AddSkillPoint(particulas, 3, "+ 3% Dano, 3% alcance", false, null);
                cargueiro.AddSkillPoint(particulas, 4, "+ 3% Dano, 3% alcance", false, null);
                cargueiro.AddSkillPoint(particulas, 5, "Habilita Partículas Duplo", false, null);
                cargueiro.AddSkillPoint(particulas, 6, "+ 3% Dano, 3% alcance", false, null);
                cargueiro.AddSkillPoint(particulas, 7, "+ 3% Dano, 3% alcance", false, null);
                cargueiro.AddSkillPoint(particulas, 8, "+ 3% Dano, 3% alcance", false, null);
                cargueiro.AddSkillPoint(particulas, 9, "+ 3% Dano, 3% alcance", false, null);
                cargueiro.AddSkillPoint(particulas, 10, "Habilita Partículas Avançado", false, null);

                cargueiro.AddSkillPoint(cofre, 1, "+ 50 cofre", false, null);
                cargueiro.AddSkillPoint(cofre, 2, "+ 50 cofre", false, null);
                cargueiro.AddSkillPoint(cofre, 3, "+ 50 cofre", false, null);
                cargueiro.AddSkillPoint(cofre, 4, "+ 50 cofre", false, null);
                cargueiro.AddSkillPoint(cofre, 5, "+ 50 cofre", false, null);

                cargueiro.AddSkillPoint(rail, 1, "Habilita Rail Básico", false, null);
                cargueiro.AddSkillPoint(rail, 2, "+ 3% Dano, 3% alcance", false, null);
                cargueiro.AddSkillPoint(rail, 3, "+ 3% Dano, 3% alcance", false, null);
                cargueiro.AddSkillPoint(rail, 4, "+ 3% Dano, 3% alcance", false, null);
                cargueiro.AddSkillPoint(rail, 5, "Habilita Rail Duplo", false, null);
                cargueiro.AddSkillPoint(rail, 6, "+ 3% Dano, 3% alcance", false, null);
                cargueiro.AddSkillPoint(rail, 7, "+ 3% Dano, 3% alcance", false, null);
                cargueiro.AddSkillPoint(rail, 8, "+ 3% Dano, 3% alcance", false, null);
                cargueiro.AddSkillPoint(rail, 9, "+ 3% Dano, 3% alcance", false, null);
                cargueiro.AddSkillPoint(rail, 10, "Habilita Rail Avançado", false, null);

                cargueiro.AddSkillPoint(blaster, 1, "Habilita Blaster Básico", false, null);
                cargueiro.AddSkillPoint(blaster, 2, "+ 3% dano, 4% velocidade projétil", false, null);
                cargueiro.AddSkillPoint(blaster, 3, "+ 3% dano, 4% velocidade projétil", false, null);
                cargueiro.AddSkillPoint(blaster, 4, "+ 3% dano, 4% velocidade projétil", false, null);
                cargueiro.AddSkillPoint(blaster, 5, "Habilita Blaster Duplo", false, null);
                cargueiro.AddSkillPoint(blaster, 6, "+ 3% dano, 4% velocidade projétil", false, null);
                cargueiro.AddSkillPoint(blaster, 7, "+ 3% dano, 4% velocidade projétil", false, null);
                cargueiro.AddSkillPoint(blaster, 8, "+ 3% dano, 4% velocidade projétil", false, null);
                cargueiro.AddSkillPoint(blaster, 9, "+ 3% dano, 4% velocidade projétil", false, null);
                cargueiro.AddSkillPoint(blaster, 10, "Habilita Blaster Avançado", false, null);

                cargueiro.AddSkillPoint(otimizacao, 1, "+ 2% container", false, null);
                cargueiro.AddSkillPoint(otimizacao, 2, "+ 2% container", false, null);
                cargueiro.AddSkillPoint(otimizacao, 3, "+ 2% container", false, null);
                cargueiro.AddSkillPoint(otimizacao, 4, "+ 2% container", false, null);
                cargueiro.AddSkillPoint(otimizacao, 5, "+ 2% container", false, null);
                cargueiro.AddSkillPoint(otimizacao, 6, "+ 2% container", false, null);
                cargueiro.AddSkillPoint(otimizacao, 7, "+ 2% container", false, null);
                cargueiro.AddSkillPoint(otimizacao, 8, "+ 2% container", false, null);
                cargueiro.AddSkillPoint(otimizacao, 9, "+ 2% container", false, null);
                cargueiro.AddSkillPoint(otimizacao, 10, "+ 2% container", false, null);

                cargueiro.AddSkillPoint(misseis, 1, "Habilita Lançador Categoria Míssel Leve", false, null);
                cargueiro.AddSkillPoint(misseis, 2, "+ 5% alcance, 3% cadência", false, null);
                cargueiro.AddSkillPoint(misseis, 3, "+ 5% alcance, 3% cadência", false, null);
                cargueiro.AddSkillPoint(misseis, 4, "+ 5% alcance, 3% cadência", false, null);
                cargueiro.AddSkillPoint(misseis, 5, "+ 5% alcance, 3% cadência", false, null);

                cargueiro.AddSkillPoint(foguetes, 1, "Habilita Lançador Categoria Foguete", false, null);
                cargueiro.AddSkillPoint(foguetes, 2, "+ 2% dano", false, null);
                cargueiro.AddSkillPoint(foguetes, 3, "+ 2% dano", false, null);
                cargueiro.AddSkillPoint(foguetes, 4, "+ 2% dano", false, null);
                cargueiro.AddSkillPoint(foguetes, 5, "+ 2% dano", false, null);

                cargueiro.AddSkillPoint(especialista, 1, "+ 2% dano em todas as minas", false, null);
                cargueiro.AddSkillPoint(especialista, 2, "+ 2% dano em todas as minas", false, null);
                cargueiro.AddSkillPoint(especialista, 3, "+ 2% dano em todas as minas", false, null);
                cargueiro.AddSkillPoint(especialista, 4, "+ 2% dano em todas as minas", false, null);
                cargueiro.AddSkillPoint(especialista, 5, "+ 2% dano em todas as minas", false, null);

                cargueiro.AddSkillPoint(casco, 1, "+ 5% casco, 4 blindagem", false, null);
                cargueiro.AddSkillPoint(casco, 2, "+ 5% casco, 4 blindagem", false, null);
                cargueiro.AddSkillPoint(casco, 3, "+ 5% casco, 4 blindagem", false, null);
                cargueiro.AddSkillPoint(casco, 4, "+ 5% casco, 4 blindagem", false, null);
                cargueiro.AddSkillPoint(casco, 5, "+ 5% casco, 4 blindagem", false, null);

                cargueiro.AddSkillPoint(mina, 1, "Habilita Lançador Categoria Mina Leve", false, null);
                cargueiro.AddSkillPoint(mina, 2, "+ 2% dano", false, null);
                cargueiro.AddSkillPoint(mina, 3, "+ 2% dano", false, null);
                cargueiro.AddSkillPoint(mina, 4, "+ 2% dano", false, null);
                cargueiro.AddSkillPoint(mina, 5, "Habilita Lançador Categoria Mina Média", false, null);
                cargueiro.AddSkillPoint(mina, 6, "+ 2% dano", false, null);
                cargueiro.AddSkillPoint(mina, 7, "+ 2% dano", false, null);
                cargueiro.AddSkillPoint(mina, 8, "+ 2% dano", false, null);
                cargueiro.AddSkillPoint(mina, 9, "+ 2% dano", false, null);
                cargueiro.AddSkillPoint(mina, 10, "Habilita Lançador Categoria Mina Pesada", false, null);

                #endregion

                #region juggernaut base

                bomber.AddSkillPoint(pilotagem, 1, "Habilita Bombardeiro Básico", true, null);
                bomber.AddSkillPoint(pilotagem, 2, "+ 3% casco, 2 blindagem, 1% cruzeiro", false, null);
                bomber.AddSkillPoint(pilotagem, 3, "+ 3% casco, 2 blindagem, 1% cruzeiro", false, null);
                bomber.AddSkillPoint(pilotagem, 4, "+ 3% casco, 2 blindagem, 1% cruzeiro", false, null);
                bomber.AddSkillPoint(pilotagem, 5, "+ 3% casco, 2 blindagem, 1% cruzeiro", false, null);
                bomber.AddSkillPoint(pilotagem, 6, "+ 3% casco, 2 blindagem, 1% cruzeiro", false, null);
                bomber.AddSkillPoint(pilotagem, 7, "+ 3% casco, 2 blindagem, 1% cruzeiro", false, null);
                bomber.AddSkillPoint(pilotagem, 8, "+Habilita Bombardeiro Intermediário", false, null);
                bomber.AddSkillPoint(pilotagem, 9, "+ 3% casco, 2 blindagem, 1% cruzeiro", false, null);
                bomber.AddSkillPoint(pilotagem, 10, "+ 3% casco, 2 blindagem, 1% cruzeiro", false, null);
                bomber.AddSkillPoint(pilotagem, 11, "+ 3% casco, 2 blindagem, 1% cruzeiro", false, null);
                bomber.AddSkillPoint(pilotagem, 12, "+ 3% casco, 2 blindagem, 1% cruzeiro", false, null);
                bomber.AddSkillPoint(pilotagem, 13, "+ 3% casco, 2 blindagem, 1% cruzeiro", false, null);
                bomber.AddSkillPoint(pilotagem, 14, "+ 3% casco, 2 blindagem, 1% cruzeiro", false, null);
                bomber.AddSkillPoint(pilotagem, 15, "Habilita Bombardeiro Avançado", false, null);

                bomber.AddSkillPoint(particulas, 1, "Habilita Partículas Básico", true, null);
                bomber.AddSkillPoint(particulas, 2, "+ 3% Dano, 3% alcance", false, null);
                bomber.AddSkillPoint(particulas, 3, "+ 3% Dano, 3% alcance", false, null);
                bomber.AddSkillPoint(particulas, 4, "+ 3% Dano, 3% alcance", false, null);
                bomber.AddSkillPoint(particulas, 5, "Habilita Partículas Duplo", false, null);
                bomber.AddSkillPoint(particulas, 6, "+ 3% Dano, 3% alcance", false, null);
                bomber.AddSkillPoint(particulas, 7, "+ 3% Dano, 3% alcance", false, null);
                bomber.AddSkillPoint(particulas, 8, "+ 3% Dano, 3% alcance", false, null);
                bomber.AddSkillPoint(particulas, 9, "+ 3% Dano, 3% alcance", false, null);
                bomber.AddSkillPoint(particulas, 10, "Habilita Partículas Avançado", false, null);

                bomber.AddSkillPoint(misseis, 1, "Habilita Lançador Categoria Míssel Leve", true, null);
                bomber.AddSkillPoint(misseis, 2, "+ 5% alcance, 3% cadência", false, null);
                bomber.AddSkillPoint(misseis, 3, "+ 5% alcance, 3% cadência", false, null);
                bomber.AddSkillPoint(misseis, 4, "+ 5% alcance, 3% cadência", false, null);
                bomber.AddSkillPoint(misseis, 5, "Habilita Lançador Categoria Míssel Médio", false, null);
                bomber.AddSkillPoint(misseis, 6, "+ 5% alcance, 3% cadência", false, null);
                bomber.AddSkillPoint(misseis, 7, "+ 5% alcance, 3% cadência", false, null);
                bomber.AddSkillPoint(misseis, 8, "+ 5% alcance, 3% cadência", false, null);
                bomber.AddSkillPoint(misseis, 9, "+ 5% alcance, 3% cadência", false, null);
                bomber.AddSkillPoint(misseis, 10, "Habilita Lançador Categoria Míssel Pesado", false, null);

                bomber.AddSkillPoint(omega, 1, "+ 5% dano, 2 segundos de duração", false, null);
                bomber.AddSkillPoint(omega, 2, "+ 5% dano, 2 segundos de duração", false, null);
                bomber.AddSkillPoint(omega, 3, "+ 5% dano, 2 segundos de duração", false, null);
                bomber.AddSkillPoint(omega, 4, "+ 5% dano, 2 segundos de duração", false, null);
                bomber.AddSkillPoint(omega, 5, "+ 5% dano, 2 segundos de duração", false, null);

                bomber.AddSkillPoint(foguetes, 1, "Habilita Lançador Categoria Foguete", false, null);
                bomber.AddSkillPoint(foguetes, 2, "+ 2% dano", false, null);
                bomber.AddSkillPoint(foguetes, 3, "+ 2% dano", false, null);
                bomber.AddSkillPoint(foguetes, 4, "+ 2% dano", false, null);
                bomber.AddSkillPoint(foguetes, 5, "+ 2% dano", false, null);
                bomber.AddSkillPoint(foguetes, 6, "+ 2% dano", false, null);
                bomber.AddSkillPoint(foguetes, 7, "+ 2% dano", false, null);
                bomber.AddSkillPoint(foguetes, 8, "+ 2% dano", false, null);
                bomber.AddSkillPoint(foguetes, 9, "+ 2% dano", false, null);
                bomber.AddSkillPoint(foguetes, 10, "+ 2% dano", false, null);

                bomber.AddSkillPoint(casco, 1, "+ 5% casco, 4 blindagem", false, null);
                bomber.AddSkillPoint(casco, 2, "+ 5% casco, 4 blindagem", false, null);
                bomber.AddSkillPoint(casco, 3, "+ 5% casco, 4 blindagem", false, null);
                bomber.AddSkillPoint(casco, 4, "+ 5% casco, 4 blindagem", false, null);
                bomber.AddSkillPoint(casco, 5, "+ 5% casco, 4 blindagem", false, null);

                bomber.AddSkillPoint(especdemoli, 1, "+ 2% dano", false, null);
                bomber.AddSkillPoint(especdemoli, 2, "+ 2% dano", false, null);
                bomber.AddSkillPoint(especdemoli, 3, "+ 2% dano", false, null);
                bomber.AddSkillPoint(especdemoli, 4, "+ 2% dano", false, null);
                bomber.AddSkillPoint(especdemoli, 5, "+ 2% dano", false, null);

                bomber.AddSkillPoint(blaster, 1, "Habilita Blaster Básico", false, null);
                bomber.AddSkillPoint(blaster, 2, "+ 3% dano, 3% velocidade projétil", false, null);
                bomber.AddSkillPoint(blaster, 3, "+ 3% dano, 3% velocidade projétil", false, null);
                bomber.AddSkillPoint(blaster, 4, "+ 3% dano, 3% velocidade projétil", false, null);
                bomber.AddSkillPoint(blaster, 5, "Habilita Blaster Duplo", false, null);

                bomber.AddSkillPoint(torpedo, 1, "Habilida Lançador Torpedo", false, null);
                bomber.AddSkillPoint(torpedo, 2, "+ 5% alcance", false, null);
                bomber.AddSkillPoint(torpedo, 3, "+ 5% alcance", false, null);
                bomber.AddSkillPoint(torpedo, 4, "+ 5% alcance", false, null);
                bomber.AddSkillPoint(torpedo, 5, "+ 5% alcance", false, null);

                bomber.AddSkillPoint(mina, 1, "Habilita Lançador Categoria Mina Leve", false, null);
                bomber.AddSkillPoint(mina, 2, "+ 2% dano", false, null);
                bomber.AddSkillPoint(mina, 3, "+ 2% dano", false, null);
                bomber.AddSkillPoint(mina, 4, "+ 2% dano", false, null);
                bomber.AddSkillPoint(mina, 5, "Habilita Lançador Categoria Mina Média", false, null);
                bomber.AddSkillPoint(mina, 6, "+ 2% dano", false, null);
                bomber.AddSkillPoint(mina, 7, "+ 2% dano", false, null);
                bomber.AddSkillPoint(mina, 8, "+ 2% dano", false, null);
                bomber.AddSkillPoint(mina, 9, "+ 2% dano", false, null);
                bomber.AddSkillPoint(mina, 10, "Habilita Lançador Categoria Mina Pesada", false, null);

                bomber.AddSkillPoint(gaus, 1, "Habilita Gauss Básico", false, null);
                bomber.AddSkillPoint(gaus, 2, "+ 3% Cadência, 3% velocidade projétil", false, null);
                bomber.AddSkillPoint(gaus, 3, "+ 3% Cadência, 3% velocidade projétil", false, null);
                bomber.AddSkillPoint(gaus, 4, "+ 3% Cadência, 3% velocidade projétil", false, null);
                bomber.AddSkillPoint(gaus, 5, "Habilita Gauss Duplo", false, null);
                bomber.AddSkillPoint(gaus, 6, "+ 3% Cadência, 3% velocidade projétil", false, null);
                bomber.AddSkillPoint(gaus, 7, "+ 3% Cadência, 3% velocidade projétil", false, null);
                bomber.AddSkillPoint(gaus, 8, "+ 3% Cadência, 3% velocidade projétil", false, null);
                bomber.AddSkillPoint(gaus, 9, "+ 3% Cadência, 3% velocidade projétil", false, null);
                bomber.AddSkillPoint(gaus, 10, "Habilita Gauss Avançado", false, null);

                bomber.AddSkillPoint(magnetica, 1, "Habilita Magnético Básico", false, null);
                bomber.AddSkillPoint(magnetica, 2, "+ 3% Cadência, 3% velocidade projétil", false, null);
                bomber.AddSkillPoint(magnetica, 3, "+ 3% Cadência, 3% velocidade projétil", false, null);
                bomber.AddSkillPoint(magnetica, 4, "+ 3% Cadência, 3% velocidade projétil", false, null);
                bomber.AddSkillPoint(magnetica, 5, "Habilita Magnético Duplo", false, null);
                bomber.AddSkillPoint(magnetica, 6, "+ 3% Cadência, 3% velocidade projétil", false, null);
                bomber.AddSkillPoint(magnetica, 7, "+ 3% Cadência, 3% velocidade projétil", false, null);
                bomber.AddSkillPoint(magnetica, 8, "+ 3% Cadência, 3% velocidade projétil", false, null);
                bomber.AddSkillPoint(magnetica, 9, "+ 3% Cadência, 3% velocidade projétil", false, null);
                bomber.AddSkillPoint(magnetica, 10, "Habilita Magnético Avançado", false, null);

                bomber.AddSkillPoint(rail, 1, "Habilita Rail Básico", false, null);
                bomber.AddSkillPoint(rail, 2, "+ 3% Dano, 3% alcance", false, null);
                bomber.AddSkillPoint(rail, 3, "+ 3% Dano, 3% alcance", false, null);
                bomber.AddSkillPoint(rail, 4, "+ 3% Dano, 3% alcance", false, null);
                bomber.AddSkillPoint(rail, 5, "Habilita Rail Duplo", false, null);
                bomber.AddSkillPoint(rail, 6, "+ 3% Dano, 3% alcance", false, null);
                bomber.AddSkillPoint(rail, 7, "+ 3% Dano, 3% alcance", false, null);
                bomber.AddSkillPoint(rail, 8, "+ 3% Dano, 3% alcance", false, null);
                bomber.AddSkillPoint(rail, 9, "+ 3% Dano, 3% alcance", false, null);
                bomber.AddSkillPoint(rail, 10, "Habilita Rail Avançado", false, null);

                bomber.AddSkillPoint(scatter, 1, "Habilita Scatter Básico", false, null);
                bomber.AddSkillPoint(scatter, 2, "+ 3% dano, 3% cadência", false, null);
                bomber.AddSkillPoint(scatter, 3, "+ 3% dano, 3% cadência", false, null);
                bomber.AddSkillPoint(scatter, 4, "+ 3% dano, 3% cadência", false, null);
                bomber.AddSkillPoint(scatter, 5, "Habilita Scatter Duplo", false, null);
                bomber.AddSkillPoint(scatter, 6, "+ 3% dano, 3% cadência", false, null);
                bomber.AddSkillPoint(scatter, 7, "+ 3% dano, 3% cadência", false, null);
                bomber.AddSkillPoint(scatter, 8, "+ 3% dano, 3% cadência", false, null);
                bomber.AddSkillPoint(scatter, 9, "+ 3% dano, 3% cadência", false, null);
                bomber.AddSkillPoint(scatter, 10, "Habilita Scatter Avançado", false, null);

                #endregion

                return new[] { hotShot, batedor, bomber, cargueiro };
            }
            else
            {
                #region Career base

                var hotShot = new Career("HotShot", 69);
                var batedor = new Career("Scoult", 69);
                var bomber = new Career("Juggernaut", 69);
                var cargueiro = new Career("Merchant", 69);

                #endregion

                #region skill base

                var pilotagem = new Skill("Pilotage");
                var afterburn = new Skill("Afterburn");
                var canhoneiro = new Skill("Embrasure");
                var escudoSuperior = new Skill("Superior Shield");
                var misseis = new Skill("Demolition: Missiles");
                var Rockets = new Skill("Demolition : Rockets");
                var rail = new Skill("Artillery: Rail");
                var gaus = new Skill("Artillery : Gauss");
                var particulas = new Skill("Artillery : Particle");
                var magnetica = new Skill("Artillery : Magnetic");
                var balistica = new Skill("Artillery : Balistic");
                var plasma = new Skill("Artillery : Plasm");
                var scatter = new Skill("Artillery : Scatter");
                var neutron = new Skill("Artillery : Neutron");
                var emboscar = new Skill("Ambush");
                var blaster = new Skill("Artillery : Blaster");
                var gerenciamento = new Skill("Energy Management");
                var antiradiacao = new Skill("Antiradiation");
                var mina = new Skill("Demolition : Mines");
                var otimizacao = new Skill("Container Optimization");
                var vault = new Skill("Vault");
                var especialista = new Skill("Mine Specialist");
                var hull = new Skill("Hull Armor");
                var omega = new Skill("OmegaStrike");
                var especdemoli = new Skill("Demolition Specialist");
                var torpedo = new Skill("Demolition : Torpedo");

                #endregion

                #region hotshot base

                hotShot.AddSkillPoint(pilotagem, 1, "Enable Basic HotShot", true, null);
                hotShot.AddSkillPoint(pilotagem, 2, "+ 3% shield, 2% aceleration, 1% speed", false, null);
                hotShot.AddSkillPoint(pilotagem, 3, "+ 3% shield, 2% aceleration, 1% speed", false, null);
                hotShot.AddSkillPoint(pilotagem, 4, "+ 3% shield, 2% aceleration, 1% speed", false, null);
                hotShot.AddSkillPoint(pilotagem, 5, "+ 3% shield, 2% aceleration, 1% speed", false, null);
                hotShot.AddSkillPoint(pilotagem, 6, "+ 3% shield, 2% aceleration, 1% speed", false, null);
                hotShot.AddSkillPoint(pilotagem, 7, "+ 3% shield, 2% aceleration, 1% speed", false, null);
                hotShot.AddSkillPoint(pilotagem, 8, "Enable Intermediat HotShot", false, null);
                hotShot.AddSkillPoint(pilotagem, 9, "+ 3% shield, 2% aceleration, 1% speed", false, null);
                hotShot.AddSkillPoint(pilotagem, 10, "+ 3% shield, 2% aceleration, 1% speed", false, null);
                hotShot.AddSkillPoint(pilotagem, 11, "+ 3% shield, 2% aceleration, 1% speed", false, null);
                hotShot.AddSkillPoint(pilotagem, 12, "+ 3% shield, 2% aceleration, 1% speed", false, null);
                hotShot.AddSkillPoint(pilotagem, 13, "+ 3% shield, 2% aceleration, 1% speed", false, null);
                hotShot.AddSkillPoint(pilotagem, 14, "+ 3% shield, 2% aceleration, 1% speed", false, null);
                hotShot.AddSkillPoint(pilotagem, 15, "Enable Advanced HotShot", false, null);

                hotShot.AddSkillPoint(gaus, 1, "Enable Basic Gauss", true, null);
                hotShot.AddSkillPoint(gaus, 2, "+ 3% firing speed, 3% bullet speed", false, null);
                hotShot.AddSkillPoint(gaus, 3, "+ 3% firing speed, 3% bullet speed", false, null);
                hotShot.AddSkillPoint(gaus, 4, "+ 3% firing speed, 3% bullet speed", false, null);
                hotShot.AddSkillPoint(gaus, 5, "Enable Double Gauss", false, null);
                hotShot.AddSkillPoint(gaus, 6, "+ 3% firing speed, 3% bullet speed", false, null);
                hotShot.AddSkillPoint(gaus, 7, "+ 3% firing speed, 3% bullet speed", false, null);
                hotShot.AddSkillPoint(gaus, 8, "+ 3% firing speed, 3% bullet speed", false, null);
                hotShot.AddSkillPoint(gaus, 9, "+ 3% firing speed, 3% bullet speed", false, null);
                hotShot.AddSkillPoint(gaus, 10, "Enable Advanced Gauss", false, null);

                hotShot.AddSkillPoint(magnetica, 1, "Enable Basic Magnetic", true, null);
                hotShot.AddSkillPoint(magnetica, 2, "+ 3% firing speed, 3% bullet speed", false, null);
                hotShot.AddSkillPoint(magnetica, 3, "+ 3% firing speed, 3% bullet speed", false, null);
                hotShot.AddSkillPoint(magnetica, 4, "+ 3% firing speed, 3% bullet speed", false, null);
                hotShot.AddSkillPoint(magnetica, 5, "Enable Double Magnetic", false, null);
                hotShot.AddSkillPoint(magnetica, 6, "+ 3% firing speed, 3% bullet speed", false, null);
                hotShot.AddSkillPoint(magnetica, 7, "+ 3% firing speed, 3% bullet speed", false, null);
                hotShot.AddSkillPoint(magnetica, 8, "+ 3% firing speed, 3% bullet speed", false, null);
                hotShot.AddSkillPoint(magnetica, 9, "+ 3% firing speed, 3% bullet speed", false, null);
                hotShot.AddSkillPoint(magnetica, 10, "Enable Advanced Magnetic", false, null);

                hotShot.AddSkillPoint(afterburn, 1, "+ 2% speed, 1 duration second", false, null);
                hotShot.AddSkillPoint(afterburn, 2, "+ 2% speed, 1 duration second", false, null);
                hotShot.AddSkillPoint(afterburn, 3, "+ 2% speed, 1 duration second", false, null);
                hotShot.AddSkillPoint(afterburn, 4, "+ 2% speed, 1 duration second", false, null);
                hotShot.AddSkillPoint(afterburn, 5, "+ 2% speed, 1 duration second", false, null);

                hotShot.AddSkillPoint(rail, 1, "Enable Basic Rail", false, null);
                hotShot.AddSkillPoint(rail, 2, "+ 3% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(rail, 3, "+ 3% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(rail, 4, "+ 3% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(rail, 5, "Enable Double Rail", false, null);
                hotShot.AddSkillPoint(rail, 6, "+ 3% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(rail, 7, "+ 3% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(rail, 8, "+ 3% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(rail, 9, "+ 3% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(rail, 10, "Enable Advanced Rail", false, null);

                hotShot.AddSkillPoint(particulas, 1, "Enable Basic Particle", false, null);
                hotShot.AddSkillPoint(particulas, 2, "+ 3% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(particulas, 3, "+ 3% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(particulas, 4, "+ 3% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(particulas, 5, "Enable Double Particle", false, null);
                hotShot.AddSkillPoint(particulas, 6, "+ 3% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(particulas, 7, "+ 3% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(particulas, 8, "+ 3% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(particulas, 9, "+ 3% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(particulas, 10, "Enable Advanced Particle", false, null);

                hotShot.AddSkillPoint(escudoSuperior, 1, "+ 5% shield, 4 regeneration", false, null);
                hotShot.AddSkillPoint(escudoSuperior, 2, "+ 5% shield, 4 regeneration", false, null);
                hotShot.AddSkillPoint(escudoSuperior, 3, "+ 5% shield, 4 regeneration", false, null);
                hotShot.AddSkillPoint(escudoSuperior, 4, "+ 5% shield, 4 regeneration", false, null);
                hotShot.AddSkillPoint(escudoSuperior, 5, "+ 5% shield, 4 regeneration", false, null);

                hotShot.AddSkillPoint(canhoneiro, 1, "+ 3% damage", false, null);
                hotShot.AddSkillPoint(canhoneiro, 2, "+ 3% damage", false, null);
                hotShot.AddSkillPoint(canhoneiro, 3, "+ 3% damage", false, null);
                hotShot.AddSkillPoint(canhoneiro, 4, "+ 3% damage", false, null);
                hotShot.AddSkillPoint(canhoneiro, 5, "+ 3% damage", false, null);

                hotShot.AddSkillPoint(misseis, 1, "Enable Launcher Category Light Missile", false, null);
                hotShot.AddSkillPoint(misseis, 2, "+ 5% reach, 3% firing speed", false, null);
                hotShot.AddSkillPoint(misseis, 3, "+ 5% reach, 3% firing speed", false, null);
                hotShot.AddSkillPoint(misseis, 4, "+ 5% reach, 3% firing speed", false, null);
                hotShot.AddSkillPoint(misseis, 5, "+ 5% reach, 3% firing speed", false, null);

                hotShot.AddSkillPoint(Rockets, 1, "Enable Launcher Category Rocket", false, null);
                hotShot.AddSkillPoint(Rockets, 2, "+ 2% damage", false, null);
                hotShot.AddSkillPoint(Rockets, 3, "+ 2% damage", false, null);
                hotShot.AddSkillPoint(Rockets, 4, "+ 2% damage", false, null);
                hotShot.AddSkillPoint(Rockets, 5, "+ 2% damage", false, null);

                hotShot.AddSkillPoint(balistica, 1, "Enable Basic Ballistic", false, null);
                hotShot.AddSkillPoint(balistica, 2, "+ 3% damage, 3% firing speed", false, null);
                hotShot.AddSkillPoint(balistica, 3, "+ 3% damage, 3% firing speed", false, null);
                hotShot.AddSkillPoint(balistica, 4, "+ 3% damage, 3% firing speed", false, null);
                hotShot.AddSkillPoint(balistica, 5, "Enable Double Ballistic", false, null);
                hotShot.AddSkillPoint(balistica, 6, "+ 3% damage, 3% firing speed", false, null);
                hotShot.AddSkillPoint(balistica, 7, "+ 3% damage, 3% firing speed", false, null);
                hotShot.AddSkillPoint(balistica, 8, "+ 3% damage, 3% firing speed", false, null);
                hotShot.AddSkillPoint(balistica, 9, "+ 3% damage, 3% firing speed", false, null);
                hotShot.AddSkillPoint(balistica, 10, "Enable Ballistic Advanced", false, null);

                hotShot.AddSkillPoint(plasma, 1, "Enable Basic Plasma", false, null);
                hotShot.AddSkillPoint(plasma, 2, "+ 2% damage, 4% firing speed", false, null);
                hotShot.AddSkillPoint(plasma, 3, "+ 2% damage, 4% firing speed", false, null);
                hotShot.AddSkillPoint(plasma, 4, "+ 2% damage, 4% firing speed", false, null);
                hotShot.AddSkillPoint(plasma, 5, "Enable Double Plasma", false, null);
                hotShot.AddSkillPoint(plasma, 6, "+ 2% damage, 4% firing speed", false, null);
                hotShot.AddSkillPoint(plasma, 7, "+ 2% damage, 4% firing speed", false, null);
                hotShot.AddSkillPoint(plasma, 8, "+ 2% damage, 4% firing speed", false, null);
                hotShot.AddSkillPoint(plasma, 9, "+ 2% damage, 4% firing speed", false, null);
                hotShot.AddSkillPoint(plasma, 10, "Enable Advanced Plasma", false, null);

                hotShot.AddSkillPoint(blaster, 1, "Enable Basic Blaster", false, null);
                hotShot.AddSkillPoint(blaster, 2, "+ 3% damage, 4% bullet speed", false, null);
                hotShot.AddSkillPoint(blaster, 3, "+ 3% damage, 4% bullet speed", false, null);
                hotShot.AddSkillPoint(blaster, 4, "+ 3% damage, 4% bullet speed", false, null);
                hotShot.AddSkillPoint(blaster, 5, "Enable Double Blaster", false, null);
                hotShot.AddSkillPoint(blaster, 6, "+ 3% damage, 4% bullet speed", false, null);
                hotShot.AddSkillPoint(blaster, 7, "+ 3% damage, 4% bullet speed", false, null);
                hotShot.AddSkillPoint(blaster, 8, "+ 3% damage, 4% bullet speed", false, null);
                hotShot.AddSkillPoint(blaster, 9, "+ 3% damage, 4% bullet speed", false, null);
                hotShot.AddSkillPoint(blaster, 10, "Enable Advanced Blaster", false, null);

                hotShot.AddSkillPoint(neutron, 1, "Enable Basic Neutron", false, null);
                hotShot.AddSkillPoint(neutron, 2, "+ 2% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(neutron, 3, "+ 2% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(neutron, 4, "+ 2% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(neutron, 5, "Enable Double Neutron", false, null);
                hotShot.AddSkillPoint(neutron, 6, "+ 2% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(neutron, 7, "+ 2% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(neutron, 8, "+ 2% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(neutron, 9, "+ 2% damage, 3% reach", false, null);
                hotShot.AddSkillPoint(neutron, 10, "Enable Advanced Neutron", false, null);

                hotShot.AddSkillPoint(scatter, 1, "Enable Basic Scatter", false, null);
                hotShot.AddSkillPoint(scatter, 2, "+ 3% damage, 3% firing speed", false, null);
                hotShot.AddSkillPoint(scatter, 3, "+ 3% damage, 3% firing speed", false, null);
                hotShot.AddSkillPoint(scatter, 4, "+ 3% damage, 3% firing speed", false, null);
                hotShot.AddSkillPoint(scatter, 5, "Enable Double Scatter", false, null);
                hotShot.AddSkillPoint(scatter, 6, "+ 3% damage, 3% firing speed", false, null);
                hotShot.AddSkillPoint(scatter, 7, "+ 3% damage, 3% firing speed", false, null);
                hotShot.AddSkillPoint(scatter, 8, "+ 3% damage, 3% firing speed", false, null);
                hotShot.AddSkillPoint(scatter, 9, "+ 3% damage, 3% firing speed", false, null);
                hotShot.AddSkillPoint(scatter, 10, "Enable Advanced Scatter", false, null);

                #endregion

                #region scoult base

                batedor.AddSkillPoint(pilotagem, 1, "Enable Basic Scoult", true, null);
                batedor.AddSkillPoint(pilotagem, 2, "+ 3% speed +2% cruizer +1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 3, "+ 3% speed +2% cruizer +1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 4, "+ 3% speed +2% cruizer +1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 5, "+ 3% speed +2% cruizer +1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 6, "+ 3% speed +2% cruizer +1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 7, "+ 3% speed +2% cruizer +1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 8, "+Enable Intermediat Scoult", false, null);
                batedor.AddSkillPoint(pilotagem, 9, "+ 3% speed +2% cruizer +1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 10, "+ 3% speed +2% cruizer +1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 11, "+ 3% speed +2% cruizer +1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 12, "+ 3% speed +2% cruizer +1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 13, "+ 3% speed +2% cruizer +1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 14, "+ 3% speed +2% cruizer +1% container", false, null);
                batedor.AddSkillPoint(pilotagem, 15, "Enable Advanced Scoult", false, null);

                batedor.AddSkillPoint(particulas, 1, "Enable Basic Particle", true, null);
                batedor.AddSkillPoint(particulas, 2, "+ 3% damage, 3% reach", false, null);
                batedor.AddSkillPoint(particulas, 3, "+ 3% damage, 3% reach", false, null);
                batedor.AddSkillPoint(particulas, 4, "+ 3% damage, 3% reach", false, null);
                batedor.AddSkillPoint(particulas, 5, "Enable Double Particle", false, null);
                batedor.AddSkillPoint(particulas, 6, "+ 3% damage, 3% reach", false, null);
                batedor.AddSkillPoint(particulas, 7, "+ 3% damage, 3% reach", false, null);
                batedor.AddSkillPoint(particulas, 8, "+ 3% damage, 3% reach", false, null);
                batedor.AddSkillPoint(particulas, 9, "+ 3% damage, 3% reach", false, null);
                batedor.AddSkillPoint(particulas, 10, "Enable Advanced Particle", false, null);

                batedor.AddSkillPoint(gerenciamento, 1, "- 0,2% cruizer activation time", true, null);
                batedor.AddSkillPoint(gerenciamento, 2, "- 0,2% cruizer activation time", false, null);
                batedor.AddSkillPoint(gerenciamento, 3, "- 0,2% cruizer activation time", false, null);
                batedor.AddSkillPoint(gerenciamento, 4, "- 0,2% cruizer activation time", false, null);
                batedor.AddSkillPoint(gerenciamento, 5, "- 0,2% cruizer activation time", false, null);
                batedor.AddSkillPoint(gerenciamento, 6, "- 0,2% cruizer activation time", false, null);
                batedor.AddSkillPoint(gerenciamento, 7, "- 0,2% cruizer activation time", false, null);
                batedor.AddSkillPoint(gerenciamento, 8, "- 0,2% cruizer activation time", false, null);
                batedor.AddSkillPoint(gerenciamento, 9, "- 0,2% cruizer activation time", false, null);
                batedor.AddSkillPoint(gerenciamento, 10, "- 0,2% cruizer activation time", false, null);

                batedor.AddSkillPoint(antiradiacao, 1, "-10% activation cost", false, null);
                batedor.AddSkillPoint(antiradiacao, 2, "-10% activation cost", false, null);
                batedor.AddSkillPoint(antiradiacao, 3, "-10% activation cost", false, null);
                batedor.AddSkillPoint(antiradiacao, 4, "-10% activation cost", false, null);
                batedor.AddSkillPoint(antiradiacao, 5, "-10% activation cost", false, null);

                batedor.AddSkillPoint(gaus, 1, "Enable Basic Gauss", true, null);
                batedor.AddSkillPoint(gaus, 2, "+ 3% firing speed, 3% bullet speed", false, null);
                batedor.AddSkillPoint(gaus, 3, "+ 3% firing speed, 3% bullet speed", false, null);
                batedor.AddSkillPoint(gaus, 4, "+ 3% firing speed, 3% bullet speed", false, null);
                batedor.AddSkillPoint(gaus, 5, "Enable Double Gauss", false, null);
                batedor.AddSkillPoint(gaus, 6, "+ 3% firing speed, 3% bullet speed", false, null);
                batedor.AddSkillPoint(gaus, 7, "+ 3% firing speed, 3% bullet speed", false, null);
                batedor.AddSkillPoint(gaus, 8, "+ 3% firing speed, 3% bullet speed", false, null);
                batedor.AddSkillPoint(gaus, 9, "+ 3% firing speed, 3% bullet speed", false, null);
                batedor.AddSkillPoint(gaus, 10, "Enable Advanced Gauss", false, null);

                batedor.AddSkillPoint(neutron, 1, "Enable Basic Neutron", false, null);
                batedor.AddSkillPoint(neutron, 2, "+ 2% damage, 3% reach", false, null);
                batedor.AddSkillPoint(neutron, 3, "+ 2% damage, 3% reach", false, null);
                batedor.AddSkillPoint(neutron, 4, "+ 2% damage, 3% reach", false, null);
                batedor.AddSkillPoint(neutron, 5, "Enable Double Neutron", false, null);
                batedor.AddSkillPoint(neutron, 6, "+ 2% damage, 3% reach", false, null);
                batedor.AddSkillPoint(neutron, 7, "+ 2% damage, 3% reach", false, null);
                batedor.AddSkillPoint(neutron, 8, "+ 2% damage, 3% reach", false, null);
                batedor.AddSkillPoint(neutron, 9, "+ 2% damage, 3% reach", false, null);
                batedor.AddSkillPoint(neutron, 10, "Enable Advanced Neutron", false, null);

                batedor.AddSkillPoint(blaster, 1, "Enable Basic Blaster", false, null);
                batedor.AddSkillPoint(blaster, 2, "+ 3% damage, 4% bullet speed", false, null);
                batedor.AddSkillPoint(blaster, 3, "+ 3% damage, 4% bullet speed", false, null);
                batedor.AddSkillPoint(blaster, 4, "+ 3% damage, 4% bullet speed", false, null);
                batedor.AddSkillPoint(blaster, 5, "Enable Double Blaster", false, null);
                batedor.AddSkillPoint(blaster, 6, "+ 3% damage, 4% bullet speed", false, null);
                batedor.AddSkillPoint(blaster, 7, "+ 3% damage, 4% bullet speed", false, null);
                batedor.AddSkillPoint(blaster, 8, "+ 3% damage, 4% bullet speed", false, null);
                batedor.AddSkillPoint(blaster, 9, "+ 3% damage, 4% bullet speed", false, null);
                batedor.AddSkillPoint(blaster, 10, "Enable Advanced Blaster", false, null);

                batedor.AddSkillPoint(misseis, 1, "Enable Launcher Category Light Missile", false, null);
                batedor.AddSkillPoint(misseis, 2, "+ 5% reach, 3% firing speed", false, null);
                batedor.AddSkillPoint(misseis, 3, "+ 5% reach, 3% firing speed", false, null);
                batedor.AddSkillPoint(misseis, 4, "+ 5% reach, 3% firing speed", false, null);
                batedor.AddSkillPoint(misseis, 5, "+ 5% reach, 3% firing speed", false, null);

                batedor.AddSkillPoint(mina, 1, "Enable Launcher Category Light Mine", false, null);
                batedor.AddSkillPoint(mina, 2, "+ 5% damage", false, null);
                batedor.AddSkillPoint(mina, 3, "+ 5% damage", false, null);
                batedor.AddSkillPoint(mina, 4, "+ 5% damage", false, null);
                batedor.AddSkillPoint(mina, 5, "Enable Launcher Category Medium Mine", false, null);

                batedor.AddSkillPoint(otimizacao, 1, "+ 2% container", false, null);
                batedor.AddSkillPoint(otimizacao, 2, "+ 2% container", false, null);
                batedor.AddSkillPoint(otimizacao, 3, "+ 2% container", false, null);
                batedor.AddSkillPoint(otimizacao, 4, "+ 2% container", false, null);
                batedor.AddSkillPoint(otimizacao, 5, "+ 2% container", false, null);

                batedor.AddSkillPoint(rail, 1, "Enable Basic Rail", false, null);
                batedor.AddSkillPoint(rail, 2, "+ 3% damage, 3% reach", false, null);
                batedor.AddSkillPoint(rail, 3, "+ 3% damage, 3% reach", false, null);
                batedor.AddSkillPoint(rail, 4, "+ 3% damage, 3% reach", false, null);
                batedor.AddSkillPoint(rail, 5, "Enable Double Rail", false, null);
                batedor.AddSkillPoint(rail, 6, "+ 3% damage, 3% reach", false, null);
                batedor.AddSkillPoint(rail, 7, "+ 3% damage, 3% reach", false, null);
                batedor.AddSkillPoint(rail, 8, "+ 3% damage, 3% reach", false, null);
                batedor.AddSkillPoint(rail, 9, "+ 3% damage, 3% reach", false, null);
                batedor.AddSkillPoint(rail, 10, "Enable Advanced Rail", false, null);

                batedor.AddSkillPoint(escudoSuperior, 1, "+ 5% shield, 4 regeneration", false, null);
                batedor.AddSkillPoint(escudoSuperior, 2, "+ 5% shield, 4 regeneration", false, null);
                batedor.AddSkillPoint(escudoSuperior, 3, "+ 5% shield, 4 regeneration", false, null);
                batedor.AddSkillPoint(escudoSuperior, 4, "+ 5% shield, 4 regeneration", false, null);
                batedor.AddSkillPoint(escudoSuperior, 5, "+ 5% shield, 4 regeneration", false, null);

                batedor.AddSkillPoint(emboscar, 1, "+ 3% reach", false, null);
                batedor.AddSkillPoint(emboscar, 2, "+ 3% reach", false, null);
                batedor.AddSkillPoint(emboscar, 3, "+ 3% reach", false, null);
                batedor.AddSkillPoint(emboscar, 4, "+ 3% reach", false, null);
                batedor.AddSkillPoint(emboscar, 5, "+ 3% reach", false, null);

                #endregion

                #region merchant base

                cargueiro.AddSkillPoint(pilotagem, 1, "Enable Basic Merchant", true, null);
                cargueiro.AddSkillPoint(pilotagem, 2, "+ 3% hull, 2% container, 1% cruizer", false, null);
                cargueiro.AddSkillPoint(pilotagem, 3, "+ 3% hull, 2% container, 1% cruizer", false, null);
                cargueiro.AddSkillPoint(pilotagem, 4, "+ 3% hull, 2% container, 1% cruizer", false, null);
                cargueiro.AddSkillPoint(pilotagem, 5, "+ 3% hull, 2% container, 1% cruizer", false, null);
                cargueiro.AddSkillPoint(pilotagem, 6, "+ 3% hull, 2% container, 1% cruizer", false, null);
                cargueiro.AddSkillPoint(pilotagem, 7, "+ 3% hull, 2% container, 1% cruizer", false, null);
                cargueiro.AddSkillPoint(pilotagem, 8, "+Enable Intermediat Merchant", false, null);
                cargueiro.AddSkillPoint(pilotagem, 9, "+ 3% hull, 2% container, 1% cruizer", false, null);
                cargueiro.AddSkillPoint(pilotagem, 10, "+ 3% hull, 2% container, 1% cruizer", false, null);
                cargueiro.AddSkillPoint(pilotagem, 11, "+ 3% hull, 2% container, 1% cruizer", false, null);
                cargueiro.AddSkillPoint(pilotagem, 12, "+ 3% hull, 2% container, 1% cruizer", false, null);
                cargueiro.AddSkillPoint(pilotagem, 13, "+ 3% hull, 2% container, 1% cruizer", false, null);
                cargueiro.AddSkillPoint(pilotagem, 14, "+ 3% hull, 2% container, 1% cruizer", false, null);
                cargueiro.AddSkillPoint(pilotagem, 15, "Enable Advanced Merchant", false, null);

                cargueiro.AddSkillPoint(gerenciamento, 1, "- 0,2% cruizer activation time", true, null);
                cargueiro.AddSkillPoint(gerenciamento, 2, "- 0,2% cruizer activation time", false, null);
                cargueiro.AddSkillPoint(gerenciamento, 3, "- 0,2% cruizer activation time", false, null);
                cargueiro.AddSkillPoint(gerenciamento, 4, "- 0,2% cruizer activation time", false, null);
                cargueiro.AddSkillPoint(gerenciamento, 5, "- 0,2% cruizer activation time", false, null);
                cargueiro.AddSkillPoint(gerenciamento, 6, "- 0,2% cruizer activation time", false, null);
                cargueiro.AddSkillPoint(gerenciamento, 7, "- 0,2% cruizer activation time", false, null);
                cargueiro.AddSkillPoint(gerenciamento, 8, "- 0,2% cruizer activation time", false, null);
                cargueiro.AddSkillPoint(gerenciamento, 9, "- 0,2% cruizer activation time", false, null);
                cargueiro.AddSkillPoint(gerenciamento, 10, "- 0,2% cruizer activation time", false, null);

                cargueiro.AddSkillPoint(particulas, 1, "Enable Basic Particle", true, null);
                cargueiro.AddSkillPoint(particulas, 2, "+ 3% damage, 3% reach", false, null);
                cargueiro.AddSkillPoint(particulas, 3, "+ 3% damage, 3% reach", false, null);
                cargueiro.AddSkillPoint(particulas, 4, "+ 3% damage, 3% reach", false, null);
                cargueiro.AddSkillPoint(particulas, 5, "Enable Double Particle", false, null);
                cargueiro.AddSkillPoint(particulas, 6, "+ 3% damage, 3% reach", false, null);
                cargueiro.AddSkillPoint(particulas, 7, "+ 3% damage, 3% reach", false, null);
                cargueiro.AddSkillPoint(particulas, 8, "+ 3% damage, 3% reach", false, null);
                cargueiro.AddSkillPoint(particulas, 9, "+ 3% damage, 3% reach", false, null);
                cargueiro.AddSkillPoint(particulas, 10, "Enable Advanced Particle", false, null);

                cargueiro.AddSkillPoint(vault, 1, "+ 50 vault", false, null);
                cargueiro.AddSkillPoint(vault, 2, "+ 50 vault", false, null);
                cargueiro.AddSkillPoint(vault, 3, "+ 50 vault", false, null);
                cargueiro.AddSkillPoint(vault, 4, "+ 50 vault", false, null);
                cargueiro.AddSkillPoint(vault, 5, "+ 50 vault", false, null);

                cargueiro.AddSkillPoint(rail, 1, "Enable Basic Rail", false, null);
                cargueiro.AddSkillPoint(rail, 2, "+ 3% damage, 3% reach", false, null);
                cargueiro.AddSkillPoint(rail, 3, "+ 3% damage, 3% reach", false, null);
                cargueiro.AddSkillPoint(rail, 4, "+ 3% damage, 3% reach", false, null);
                cargueiro.AddSkillPoint(rail, 5, "Enable Double Rail", false, null);
                cargueiro.AddSkillPoint(rail, 6, "+ 3% damage, 3% reach", false, null);
                cargueiro.AddSkillPoint(rail, 7, "+ 3% damage, 3% reach", false, null);
                cargueiro.AddSkillPoint(rail, 8, "+ 3% damage, 3% reach", false, null);
                cargueiro.AddSkillPoint(rail, 9, "+ 3% damage, 3% reach", false, null);
                cargueiro.AddSkillPoint(rail, 10, "Enable Advanced Rail", false, null);

                cargueiro.AddSkillPoint(blaster, 1, "Enable Basic Blaster", false, null);
                cargueiro.AddSkillPoint(blaster, 2, "+ 3% damage, 4% bullet speed", false, null);
                cargueiro.AddSkillPoint(blaster, 3, "+ 3% damage, 4% bullet speed", false, null);
                cargueiro.AddSkillPoint(blaster, 4, "+ 3% damage, 4% bullet speed", false, null);
                cargueiro.AddSkillPoint(blaster, 5, "Enable Double Blaster", false, null);
                cargueiro.AddSkillPoint(blaster, 6, "+ 3% damage, 4% bullet speed", false, null);
                cargueiro.AddSkillPoint(blaster, 7, "+ 3% damage, 4% bullet speed", false, null);
                cargueiro.AddSkillPoint(blaster, 8, "+ 3% damage, 4% bullet speed", false, null);
                cargueiro.AddSkillPoint(blaster, 9, "+ 3% damage, 4% bullet speed", false, null);
                cargueiro.AddSkillPoint(blaster, 10, "Enable Advanced Blaster", false, null);

                cargueiro.AddSkillPoint(otimizacao, 1, "+ 2% container", false, null);
                cargueiro.AddSkillPoint(otimizacao, 2, "+ 2% container", false, null);
                cargueiro.AddSkillPoint(otimizacao, 3, "+ 2% container", false, null);
                cargueiro.AddSkillPoint(otimizacao, 4, "+ 2% container", false, null);
                cargueiro.AddSkillPoint(otimizacao, 5, "+ 2% container", false, null);
                cargueiro.AddSkillPoint(otimizacao, 6, "+ 2% container", false, null);
                cargueiro.AddSkillPoint(otimizacao, 7, "+ 2% container", false, null);
                cargueiro.AddSkillPoint(otimizacao, 8, "+ 2% container", false, null);
                cargueiro.AddSkillPoint(otimizacao, 9, "+ 2% container", false, null);
                cargueiro.AddSkillPoint(otimizacao, 10, "+ 2% container", false, null);

                cargueiro.AddSkillPoint(misseis, 1, "Enable Launcher Category Light Missile", false, null);
                cargueiro.AddSkillPoint(misseis, 2, "+ 5% reach, 3% firing speed", false, null);
                cargueiro.AddSkillPoint(misseis, 3, "+ 5% reach, 3% firing speed", false, null);
                cargueiro.AddSkillPoint(misseis, 4, "+ 5% reach, 3% firing speed", false, null);
                cargueiro.AddSkillPoint(misseis, 5, "+ 5% reach, 3% firing speed", false, null);

                cargueiro.AddSkillPoint(Rockets, 1, "Enable Launcher Category Rocket", false, null);
                cargueiro.AddSkillPoint(Rockets, 2, "+ 2% damage", false, null);
                cargueiro.AddSkillPoint(Rockets, 3, "+ 2% damage", false, null);
                cargueiro.AddSkillPoint(Rockets, 4, "+ 2% damage", false, null);
                cargueiro.AddSkillPoint(Rockets, 5, "+ 2% damage", false, null);

                cargueiro.AddSkillPoint(especialista, 1, "+ 2% damage in all mines", false, null);
                cargueiro.AddSkillPoint(especialista, 2, "+ 2% damage in all mines", false, null);
                cargueiro.AddSkillPoint(especialista, 3, "+ 2% damage in all mines", false, null);
                cargueiro.AddSkillPoint(especialista, 4, "+ 2% damage in all mines", false, null);
                cargueiro.AddSkillPoint(especialista, 5, "+ 2% damage in all mines", false, null);

                cargueiro.AddSkillPoint(hull, 1, "+ 5% hull, 4 armor", false, null);
                cargueiro.AddSkillPoint(hull, 2, "+ 5% hull, 4 armor", false, null);
                cargueiro.AddSkillPoint(hull, 3, "+ 5% hull, 4 armor", false, null);
                cargueiro.AddSkillPoint(hull, 4, "+ 5% hull, 4 armor", false, null);
                cargueiro.AddSkillPoint(hull, 5, "+ 5% hull, 4 armor", false, null);

                cargueiro.AddSkillPoint(mina, 1, "Enable Launcher Category Light Mine", false, null);
                cargueiro.AddSkillPoint(mina, 2, "+ 2% damage", false, null);
                cargueiro.AddSkillPoint(mina, 3, "+ 2% damage", false, null);
                cargueiro.AddSkillPoint(mina, 4, "+ 2% damage", false, null);
                cargueiro.AddSkillPoint(mina, 5, "Enable Launcher Category Medium Mine", false, null);
                cargueiro.AddSkillPoint(mina, 6, "+ 2% damage", false, null);
                cargueiro.AddSkillPoint(mina, 7, "+ 2% damage", false, null);
                cargueiro.AddSkillPoint(mina, 8, "+ 2% damage", false, null);
                cargueiro.AddSkillPoint(mina, 9, "+ 2% damage", false, null);
                cargueiro.AddSkillPoint(mina, 10, "Enable Launcher Category Hard Mine", false, null);

                #endregion

                #region juggernaut base

                bomber.AddSkillPoint(pilotagem, 1, "Enable Basic Bomber", true, null);
                bomber.AddSkillPoint(pilotagem, 2, "+ 3% hull, 2 armor, 1% cruizer", false, null);
                bomber.AddSkillPoint(pilotagem, 3, "+ 3% hull, 2 armor, 1% cruizer", false, null);
                bomber.AddSkillPoint(pilotagem, 4, "+ 3% hull, 2 armor, 1% cruizer", false, null);
                bomber.AddSkillPoint(pilotagem, 5, "+ 3% hull, 2 armor, 1% cruizer", false, null);
                bomber.AddSkillPoint(pilotagem, 6, "+ 3% hull, 2 armor, 1% cruizer", false, null);
                bomber.AddSkillPoint(pilotagem, 7, "+ 3% hull, 2 armor, 1% cruizer", false, null);
                bomber.AddSkillPoint(pilotagem, 8, "+Enable Intermediat Bomber", false, null);
                bomber.AddSkillPoint(pilotagem, 9, "+ 3% hull, 2 armor, 1% cruizer", false, null);
                bomber.AddSkillPoint(pilotagem, 10, "+ 3% hull, 2 armor, 1% cruizer", false, null);
                bomber.AddSkillPoint(pilotagem, 11, "+ 3% hull, 2 armor, 1% cruizer", false, null);
                bomber.AddSkillPoint(pilotagem, 12, "+ 3% hull, 2 armor, 1% cruizer", false, null);
                bomber.AddSkillPoint(pilotagem, 13, "+ 3% hull, 2 armor, 1% cruizer", false, null);
                bomber.AddSkillPoint(pilotagem, 14, "+ 3% hull, 2 armor, 1% cruizer", false, null);
                bomber.AddSkillPoint(pilotagem, 15, "Enable Advanced Bomber", false, null);

                bomber.AddSkillPoint(particulas, 1, "Enable Basic Particle", true, null);
                bomber.AddSkillPoint(particulas, 2, "+ 3% damage, 3% reach", false, null);
                bomber.AddSkillPoint(particulas, 3, "+ 3% damage, 3% reach", false, null);
                bomber.AddSkillPoint(particulas, 4, "+ 3% damage, 3% reach", false, null);
                bomber.AddSkillPoint(particulas, 5, "Enable Double Particle", false, null);
                bomber.AddSkillPoint(particulas, 6, "+ 3% damage, 3% reach", false, null);
                bomber.AddSkillPoint(particulas, 7, "+ 3% damage, 3% reach", false, null);
                bomber.AddSkillPoint(particulas, 8, "+ 3% damage, 3% reach", false, null);
                bomber.AddSkillPoint(particulas, 9, "+ 3% damage, 3% reach", false, null);
                bomber.AddSkillPoint(particulas, 10, "Enable Advanced Particle", false, null);

                bomber.AddSkillPoint(misseis, 1, "Enable Launcher Category Light Missile", true, null);
                bomber.AddSkillPoint(misseis, 2, "+ 5% reach, 3% firing speed", false, null);
                bomber.AddSkillPoint(misseis, 3, "+ 5% reach, 3% firing speed", false, null);
                bomber.AddSkillPoint(misseis, 4, "+ 5% reach, 3% firing speed", false, null);
                bomber.AddSkillPoint(misseis, 5, "Enable Launcher Category Medium Missile", false, null);
                bomber.AddSkillPoint(misseis, 6, "+ 5% reach, 3% firing speed", false, null);
                bomber.AddSkillPoint(misseis, 7, "+ 5% reach, 3% firing speed", false, null);
                bomber.AddSkillPoint(misseis, 8, "+ 5% reach, 3% firing speed", false, null);
                bomber.AddSkillPoint(misseis, 9, "+ 5% reach, 3% firing speed", false, null);
                bomber.AddSkillPoint(misseis, 10, "Enable Launcher Category Hard Missile", false, null);

                bomber.AddSkillPoint(omega, 1, "+ 5% damage, 2 duration seconds", false, null);
                bomber.AddSkillPoint(omega, 2, "+ 5% damage, 2 duration seconds", false, null);
                bomber.AddSkillPoint(omega, 3, "+ 5% damage, 2 duration seconds", false, null);
                bomber.AddSkillPoint(omega, 4, "+ 5% damage, 2 duration seconds", false, null);
                bomber.AddSkillPoint(omega, 5, "+ 5% damage, 2 duration seconds", false, null);

                bomber.AddSkillPoint(Rockets, 1, "Enable Launcher Category Rocket", false, null);
                bomber.AddSkillPoint(Rockets, 2, "+ 2% damage", false, null);
                bomber.AddSkillPoint(Rockets, 3, "+ 2% damage", false, null);
                bomber.AddSkillPoint(Rockets, 4, "+ 2% damage", false, null);
                bomber.AddSkillPoint(Rockets, 5, "+ 2% damage", false, null);
                bomber.AddSkillPoint(Rockets, 6, "+ 2% damage", false, null);
                bomber.AddSkillPoint(Rockets, 7, "+ 2% damage", false, null);
                bomber.AddSkillPoint(Rockets, 8, "+ 2% damage", false, null);
                bomber.AddSkillPoint(Rockets, 9, "+ 2% damage", false, null);
                bomber.AddSkillPoint(Rockets, 10, "+ 2% damage", false, null);

                bomber.AddSkillPoint(hull, 1, "+ 5% hull, 4 armor", false, null);
                bomber.AddSkillPoint(hull, 2, "+ 5% hull, 4 armor", false, null);
                bomber.AddSkillPoint(hull, 3, "+ 5% hull, 4 armor", false, null);
                bomber.AddSkillPoint(hull, 4, "+ 5% hull, 4 armor", false, null);
                bomber.AddSkillPoint(hull, 5, "+ 5% hull, 4 armor", false, null);

                bomber.AddSkillPoint(especdemoli, 1, "+ 2% damage", false, null);
                bomber.AddSkillPoint(especdemoli, 2, "+ 2% damage", false, null);
                bomber.AddSkillPoint(especdemoli, 3, "+ 2% damage", false, null);
                bomber.AddSkillPoint(especdemoli, 4, "+ 2% damage", false, null);
                bomber.AddSkillPoint(especdemoli, 5, "+ 2% damage", false, null);

                bomber.AddSkillPoint(blaster, 1, "Enable Basic Blaster", false, null);
                bomber.AddSkillPoint(blaster, 2, "+ 3% damage, 3% bullet speed", false, null);
                bomber.AddSkillPoint(blaster, 3, "+ 3% damage, 3% bullet speed", false, null);
                bomber.AddSkillPoint(blaster, 4, "+ 3% damage, 3% bullet speed", false, null);
                bomber.AddSkillPoint(blaster, 5, "Enable Double Blaster", false, null);

                bomber.AddSkillPoint(torpedo, 1, "Enable Launcher Torpedo", false, null);
                bomber.AddSkillPoint(torpedo, 2, "+ 5% reach", false, null);
                bomber.AddSkillPoint(torpedo, 3, "+ 5% reach", false, null);
                bomber.AddSkillPoint(torpedo, 4, "+ 5% reach", false, null);
                bomber.AddSkillPoint(torpedo, 5, "+ 5% reach", false, null);

                bomber.AddSkillPoint(mina, 1, "Enable Launcher Category Light Mine", false, null);
                bomber.AddSkillPoint(mina, 2, "+ 2% damage", false, null);
                bomber.AddSkillPoint(mina, 3, "+ 2% damage", false, null);
                bomber.AddSkillPoint(mina, 4, "+ 2% damage", false, null);
                bomber.AddSkillPoint(mina, 5, "Enable Launcher Category Medium Mine", false, null);
                bomber.AddSkillPoint(mina, 6, "+ 2% damage", false, null);
                bomber.AddSkillPoint(mina, 7, "+ 2% damage", false, null);
                bomber.AddSkillPoint(mina, 8, "+ 2% damage", false, null);
                bomber.AddSkillPoint(mina, 9, "+ 2% damage", false, null);
                bomber.AddSkillPoint(mina, 10, "Enable Launcher Category Hard Mine", false, null);

                bomber.AddSkillPoint(gaus, 1, "Enable Basic Gauss", false, null);
                bomber.AddSkillPoint(gaus, 2, "+ 3% firing speed, 3% bullet speed", false, null);
                bomber.AddSkillPoint(gaus, 3, "+ 3% firing speed, 3% bullet speed", false, null);
                bomber.AddSkillPoint(gaus, 4, "+ 3% firing speed, 3% bullet speed", false, null);
                bomber.AddSkillPoint(gaus, 5, "Enable Double Gauss", false, null);
                bomber.AddSkillPoint(gaus, 6, "+ 3% firing speed, 3% bullet speed", false, null);
                bomber.AddSkillPoint(gaus, 7, "+ 3% firing speed, 3% bullet speed", false, null);
                bomber.AddSkillPoint(gaus, 8, "+ 3% firing speed, 3% bullet speed", false, null);
                bomber.AddSkillPoint(gaus, 9, "+ 3% firing speed, 3% bullet speed", false, null);
                bomber.AddSkillPoint(gaus, 10, "Enable Advanced Gauss", false, null);

                bomber.AddSkillPoint(magnetica, 1, "Enable Magnetic Basic", false, null);
                bomber.AddSkillPoint(magnetica, 2, "+ 3% firing speed, 3% bullet speed", false, null);
                bomber.AddSkillPoint(magnetica, 3, "+ 3% firing speed, 3% bullet speed", false, null);
                bomber.AddSkillPoint(magnetica, 4, "+ 3% firing speed, 3% bullet speed", false, null);
                bomber.AddSkillPoint(magnetica, 5, "Enable Double Magnetic", false, null);
                bomber.AddSkillPoint(magnetica, 6, "+ 3% firing speed, 3% bullet speed", false, null);
                bomber.AddSkillPoint(magnetica, 7, "+ 3% firing speed, 3% bullet speed", false, null);
                bomber.AddSkillPoint(magnetica, 8, "+ 3% firing speed, 3% bullet speed", false, null);
                bomber.AddSkillPoint(magnetica, 9, "+ 3% firing speed, 3% bullet speed", false, null);
                bomber.AddSkillPoint(magnetica, 10, "Enable Advanced Magnetic", false, null);

                bomber.AddSkillPoint(rail, 1, "Enable Basic Rail", false, null);
                bomber.AddSkillPoint(rail, 2, "+ 3% damage, 3% reach", false, null);
                bomber.AddSkillPoint(rail, 3, "+ 3% damage, 3% reach", false, null);
                bomber.AddSkillPoint(rail, 4, "+ 3% damage, 3% reach", false, null);
                bomber.AddSkillPoint(rail, 5, "Enable Double Rail", false, null);
                bomber.AddSkillPoint(rail, 6, "+ 3% damage, 3% reach", false, null);
                bomber.AddSkillPoint(rail, 7, "+ 3% damage, 3% reach", false, null);
                bomber.AddSkillPoint(rail, 8, "+ 3% damage, 3% reach", false, null);
                bomber.AddSkillPoint(rail, 9, "+ 3% damage, 3% reach", false, null);
                bomber.AddSkillPoint(rail, 10, "Enable Advanced Rail", false, null);

                bomber.AddSkillPoint(scatter, 1, "Enable Basic Scatter", false, null);
                bomber.AddSkillPoint(scatter, 2, "+ 3% damage, 3% firing speed", false, null);
                bomber.AddSkillPoint(scatter, 3, "+ 3% damage, 3% firing speed", false, null);
                bomber.AddSkillPoint(scatter, 4, "+ 3% damage, 3% firing speed", false, null);
                bomber.AddSkillPoint(scatter, 5, "Enable Double Scatter", false, null);
                bomber.AddSkillPoint(scatter, 6, "+ 3% damage, 3% firing speed", false, null);
                bomber.AddSkillPoint(scatter, 7, "+ 3% damage, 3% firing speed", false, null);
                bomber.AddSkillPoint(scatter, 8, "+ 3% damage, 3% firing speed", false, null);
                bomber.AddSkillPoint(scatter, 9, "+ 3% damage, 3% firing speed", false, null);
                bomber.AddSkillPoint(scatter, 10, "Enable Advanced Scatter", false, null);

                #endregion

                return new[] { hotShot, batedor, bomber, cargueiro };
            }
            
            //return null;//new[] { hotShot, batedor, bomber, cargueiro };
        }
    }
}